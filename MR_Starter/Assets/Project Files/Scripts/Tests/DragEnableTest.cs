using MixedRealityToolkit.InputModule.Utilities.Interations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragEnableTest : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ToggleDraggable()
    {
        var dragabble = GetComponent<HandDraggable>();
        dragabble.IsDraggingEnabled = !dragabble.IsDraggingEnabled;
    }
}
