using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scheduler : MonoBehaviour
{
    public static Scheduler instance { get; private set; }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }

    public void Schedule(float delay, Action act)
    {
        var coro = RunDelay(delay, act);
        StartCoroutine(coro);
    }

    IEnumerator RunDelay(float delay, Action act)
    {
        yield return new WaitForSeconds(delay);
        act();
    }
}