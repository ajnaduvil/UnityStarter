using MixedRealityToolkit.InputModule;
using MixedRealityToolkit.InputModule.EventData;
using MixedRealityToolkit.InputModule.InputHandlers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OnDoublTapEvent : MonoBehaviour, IInputClickHandler
{

    public UnityEvent OnDoubleTappedEvent;
    private int clickCount = 0;

    private float waitDelay = .5f;
    private Coroutine delayRoutine;

    void OnDoubleTapped()
    {
        OnDoubleTappedEvent.Invoke();

    }



    IEnumerator waitForDoubleClick()
    {
        var startTime = Time.timeSinceLevelLoad;
        var currentTime = Time.timeSinceLevelLoad;
        var timeDiff = currentTime - startTime;
        do
        {
            currentTime = Time.timeSinceLevelLoad;
            timeDiff = currentTime - startTime;
            if (clickCount >= 2)
            {

                OnDoubleTapped();
                clickCount = 0;
                yield break;
            }
            yield return null;
        } while (timeDiff < waitDelay);
        // yield return new WaitForSeconds(.5f);


        clickCount = 0;
    }



    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void IInputClickHandler.OnInputClicked(InputClickedEventData eventData)
    {

        clickCount++;
        if (clickCount == 1)
        {
            if (delayRoutine != null)
            {
                StopCoroutine(delayRoutine);
                delayRoutine = null;
            }
          delayRoutine =  StartCoroutine(waitForDoubleClick());
        }
        eventData.Use();
        Debug.Log("click" +clickCount);
    }


}
