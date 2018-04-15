using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class AppManager : MonoBehaviour
{
    public static AppManager Instance;

    [HideInInspector]
    public AppModeState currentAppState;
    private AppModeState previousState;

 

    public enum PetTrackable { None, Dog, Eat, Walk, Drink ,Game}

    void Awake()
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

    // Use this for initialization
    void Start()
    {
        previousState = null;
        currentAppState = null;
        ResetStates();       
        SwitchState(SampleState.Instance);
    }

    private void ResetStates()
    {
        var states = FindObjectsOfType<AppModeState>();
        foreach (var state in states)
        {
            state.ResetState();
        }
    }

    public void SwitchState(AppModeState newState)
    {
        if (currentAppState != null)
        {
            currentAppState.OnExit();
        }
        previousState = currentAppState;
        currentAppState = newState;
        currentAppState.OnEnter();
    }

    // Update is called once per frame
    void Update()
    {

    }

  

    public void TargetFound(TrackableBehaviour imageTargetBehaviour, GameObject callerObject)
    {
      
    }

    public void TargetLost(TrackableBehaviour imageTargetBehaviour, GameObject callerObject)
    {
       
    }



 
}
