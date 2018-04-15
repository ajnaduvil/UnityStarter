using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class SampleState : AppModeState
{
    public static SampleState Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this);
        }
    }
    
    public override void OnEnter()
    {
        base.OnEnter();
            

    }

    public override void OnExit()
    {
        base.OnExit();
        StopAllCoroutines();
    }

    // Use this for initialization
    void Start()
    {
        base.Start();
    }

    // Update is called once per frame
    void Update()
    {

    }

    //private IEnumerator DisableVuforiaCamera()
    //{
    //    while (!CameraDevice.Instance.IsActive())
    //    {
    //        yield return null;
    //    }
    //    CameraDevice.Instance.Stop();
    //}

    public override void ResetState()
    {
        base.ResetState();
    }

    public override void OnTargetFound(TrackableBehaviour imageTarget, GameObject callerObject)
    {
        throw new System.NotImplementedException();
    }

    public override void OnTargetLost(TrackableBehaviour imageTarget, GameObject callerObject)
    {
        throw new System.NotImplementedException();
    }
}
