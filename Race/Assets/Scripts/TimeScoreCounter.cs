using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeScoreCounter : MonoBehaviour
{
    private float startTime;
    private float elapsedtime;

    private void Start()
    {
        startTime = Time.time;
    }

    private void Update()
    {
        elapsedtime = Time.time - startTime;
    }

    public float GetElapsedtime()
    {
        return elapsedtime;
    }
}
