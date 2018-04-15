using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppUtils
{
    public static void EnableObjects(GameObject[] objectArray, bool flag)
    {
        foreach (GameObject obj in objectArray)
        {
            obj.SetActive(flag);
        }
    }
}
