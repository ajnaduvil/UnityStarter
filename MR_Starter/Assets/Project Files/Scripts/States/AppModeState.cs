using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public abstract class AppModeState : MonoBehaviour
{
    public GameObject[] enableObjects;
    public GameObject[] disableObjects;

    public abstract void OnTargetFound(TrackableBehaviour imageTarget, GameObject callerObject);
    public abstract void OnTargetLost(TrackableBehaviour imageTarget, GameObject callerObject);

    public void Start()
    {
       
        Debug.Log("AppModeState Start"+this.gameObject.name);

    }
    public virtual void OnEnter()
    {
        AppUtils.EnableObjects(enableObjects, true);
        AppUtils.EnableObjects(disableObjects, false);

       
    }

    public virtual void OnExit()
    {
        AppUtils.EnableObjects(enableObjects, false);
        AppUtils.EnableObjects(disableObjects, true);
    }

    public virtual void ResetState()
    {
        if (enableObjects!=null)
        {
            AppUtils.EnableObjects(enableObjects, false);
        }

    }

}
