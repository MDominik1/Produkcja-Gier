using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Range(0f,5f)]
    public float delay = 1f;
    
    private void Start()
    {
        Action act = () =>
        {
            Debug.Log("Hello");
        };
        Scheduler.instance.Schedule(delay, act);
    }
}