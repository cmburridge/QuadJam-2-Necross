using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerEvent : MonoBehaviour
{
    public UnityEvent isTriggered;

    public UnityEvent notTriggered;

    public bool hasTriggered = false;

    public bool isMirror = false;

    public float timer = 0;
    public float timerMax = 20;

    private void Update()
    {
        if (timer == timerMax)
        {
            timer -= 1 * Time.deltaTime;
        }

        if (hasTriggered == true)
        {
            Destroy(this);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (isMirror == true && timer <= 0)
        {
            isTriggered.Invoke();
            timer = timerMax;
        }
        else
        {
            isTriggered.Invoke();
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        notTriggered.Invoke();
    }

    public void TurnOff()
    {
        hasTriggered = true;
    }
}
