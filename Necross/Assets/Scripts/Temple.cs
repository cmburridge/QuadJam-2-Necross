using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Temple : MonoBehaviour
{
    public FloatData size;
    public float amount;

    private void Start()
    {
        size.value += amount;
    }
}
