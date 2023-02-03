using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalTimer : MonoBehaviour
{
    public float timer = 10;
    public float timerMax = 15;
    public float timeDecrease = 1;

    public GameObject spawner;

    private void Update()
    {
        timer -= timeDecrease * Time.deltaTime;
        if (timer <= 0)
        {
            spawner.SetActive(true);
            timer = timerMax;
        }
    }
}
