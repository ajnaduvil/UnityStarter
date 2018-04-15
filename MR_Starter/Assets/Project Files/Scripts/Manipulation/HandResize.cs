
using MixedRealityToolkit.InputModule;
using MixedRealityToolkit.InputModule.EventData;
using MixedRealityToolkit.InputModule.InputHandlers;
using UnityEngine;

public class HandResize : MonoBehaviour, IManipulationHandler
{
    [Tooltip("Speed at which the object is resized.")]
    [SerializeField]
    float ResizeSpeedFactor = 1.5f;

    [SerializeField]
    float ResizeScaleFactor = 1.5f;

    [Tooltip("When warp is checked, we allow resizing of all three scale axes - otherwise we scale each axis by the same amount.")]
    [SerializeField]
    bool AllowResizeWarp = false;

    [Tooltip("Minimum resize scale allowed.")]
    [SerializeField]
    float MinScale = 0.5f;

    [Tooltip("Maximum resize scale allowed.")]
    [SerializeField]
    float MaxScale = 4f;

    [SerializeField]
    bool resizingEnabled = true;

    Vector3 lastScale;

    public void SetResizing(bool enabled)
    {
        resizingEnabled = enabled;
    }

    public void OnManipulationStarted(ManipulationEventData eventData)
    {
        if (resizingEnabled)
        {
            InputManager.Instance.PushModalInputHandler(gameObject);
            InputManager.Instance.OverrideFocusedObject = gameObject;
            lastScale = transform.localScale;
            eventData.Use();
        }

    }

    public void OnManipulationUpdated(ManipulationEventData eventData)
    {
        if (resizingEnabled)
        {
            Resize(eventData.CumulativeDelta);
            eventData.Use();

            //sharing & messaging
            //SharingMessages.Instance.SendResizing(Id, eventData.CumulativeDelta);
        }
    }

    public void OnManipulationCompleted(ManipulationEventData eventData)
    {
        if (resizingEnabled)
        {
            InputManager.Instance.PopModalInputHandler();
            InputManager.Instance.OverrideFocusedObject = null;

            eventData.Use();

        }
    }

    public void OnManipulationCanceled(ManipulationEventData eventData)
    {
        if (resizingEnabled)
        {
            InputManager.Instance.PopModalInputHandler();
            InputManager.Instance.OverrideFocusedObject = null;

            eventData.Use();

        }
    }
    void Resize(Vector3 newScale)
    {
        float resizeX, resizeY, resizeZ;
        //if we are warping, honor axis delta, else take the x
        if (AllowResizeWarp)
        {
            resizeX = newScale.x * ResizeScaleFactor;
            resizeY = newScale.y * ResizeScaleFactor;
            resizeZ = newScale.z * ResizeScaleFactor;
        }
        else
        {
            resizeX = resizeY = resizeZ = newScale.x * ResizeScaleFactor;
        }

        resizeX = Mathf.Clamp(lastScale.x + resizeX, MinScale, MaxScale);
        resizeY = Mathf.Clamp(lastScale.y + resizeY, MinScale, MaxScale);
        resizeZ = Mathf.Clamp(lastScale.z + resizeZ, MinScale, MaxScale);

        transform.localScale = Vector3.Lerp(transform.localScale,
            new Vector3(resizeX, resizeY, resizeZ),
            ResizeSpeedFactor);
    }

}
