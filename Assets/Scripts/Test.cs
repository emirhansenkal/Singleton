using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;

public class Test : MonoBehaviour
{
    private void Start()
    {
        Debug.Log(Singleton.GetInstance().GetText());
    }

    private void Update()
    {
        Debug.Log(UnitySingleton.Instance.GetText());
        Debug.Log(GameManager.Instance.GetText());
    }
}
