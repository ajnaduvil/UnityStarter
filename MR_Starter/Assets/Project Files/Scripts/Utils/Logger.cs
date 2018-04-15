using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Logger {
  
    public static bool isLogEnabled = true;	

    public static void  Log(string message)
    {
        if(isLogEnabled)
        Debug.Log(message);
    }
}