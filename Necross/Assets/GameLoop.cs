using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameLoop : MonoBehaviour
{
    public IntData UndeadCount;
    public UnityEvent firstMilestone;
    public UnityEvent secondMilestone;

    private void Update()
    {
        if (UndeadCount.value >= 500)
        {
            firstMilestone.Invoke();
        }
        
        if (UndeadCount.value >= 1000)
        {
            secondMilestone.Invoke();
        }
    }
}
