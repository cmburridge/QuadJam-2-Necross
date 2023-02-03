using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grimiore : MonoBehaviour
{
    public FloatData time;
    public float amount;
    public float min;
    
    private void Start()
    {
        if (time.value <= min)
        {
            time.value = min;
        }
        else
        {
            time.value -= amount;
        }
    }
}
