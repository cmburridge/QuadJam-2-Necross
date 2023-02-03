using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alter : MonoBehaviour
{
    public BoolData isOn;
    public IntData maxRandom;

    private void Start()
    {
        isOn.isOn = true;

        maxRandom.value -= 2;
    }
}
