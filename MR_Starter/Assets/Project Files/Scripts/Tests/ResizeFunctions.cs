using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResizeFunctions : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void MakeBigger()
    {
        transform.localScale *= .2f;
    }
    public void MakeSmaller()
    {
        transform.localScale /= .2f;
    }

    
}
