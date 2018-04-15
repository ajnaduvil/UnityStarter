using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MixedRealityToolkit.InputModule;
using MixedRealityToolkit.InputModule.EventData;
using MixedRealityToolkit.InputModule.Focus;
using MixedRealityToolkit.InputModule.InputHandlers;
using MixedRealityToolkit.InputModule.InputSources;

public class WaitTest : MonoBehaviour
{

    public bool isEnable = true;
    // Use this for initialization
    void Start()
    {
        //        InputManager.Instance;

    }

    // Update is called once per frame
    void Update()
    {

    }


    public void Wait()
    {
        InputManager.Instance.PushInputDisable();

    }
    public void StopWaiting()
    {
        InputManager.Instance.PopInputDisable();

    }

}
