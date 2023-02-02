using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grimiore : MonoBehaviour
{
    public FloatData time;
    public float amount;
    
    private void Start()
    {
        time.value -= amount;
    }
}
