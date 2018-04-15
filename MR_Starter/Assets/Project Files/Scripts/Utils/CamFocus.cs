using UnityEngine;
//using Vuforia;
using System;
using System.Collections;

// Functions to set the focus mode of a vuforia application
public class CamFocus : MonoBehaviour
{
    // TODO make nessessary changes to fit the applications use case
   
    private void Start()
    {
        // Triggerring Autofocus
        InvokeRepeating("setFocusModeAuto", 10, 10);
    }

    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //if (CameraDevice.Instance.IsActive())
            //{
            //  //  if (AppManager.instance.currentState == AppManager.APPSTATE.SEARCHING && !carObject.activeSelf)

            //  //  {
            //  ////      CameraDevice.Instance.SetFocusMode(CameraDevice.FocusMode.FOCUS_MODE_TRIGGERAUTO);
                   
            //  //  }
            //}
        }
        
    }

    private void setFocusModeAuto()
    {
        //if (CameraDevice.Instance.IsActive())
        //{
        //    if (AppManager.instance.currentState == AppManager.APPSTATE.SEARCHING && !carObject.activeSelf)
        //    {
        //        CameraDevice.Instance.SetFocusMode(CameraDevice.FocusMode.FOCUS_MODE_TRIGGERAUTO);
        //        // CameraDevice.Instance.SetFocusMode(CameraDevice.FocusMode.FOCUS_MODE_CONTINUOUSAUTO);
        //        StartCoroutine(setAutoMode());
        //    }
        //}
    }

    IEnumerator setAutoMode()
    {
        //yield return new WaitForSeconds(2);
        //CameraDevice.Instance.SetFocusMode(CameraDevice.FocusMode.FOCUS_MODE_CONTINUOUSAUTO);

        yield return null;
    }
    
}

