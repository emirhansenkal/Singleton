using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitySingleton : MonoBehaviour
{
    private string text;
    
    private static UnitySingleton instance = null;

    public static UnitySingleton Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new GameObject("Singleton").AddComponent<UnitySingleton>();
            }
            
            return instance;
        }
    }

    private void OnEnable()
    {
        instance = this;
        text = "Hello World";
    }

    public string GetText()
    {
        return text;
    }

}
