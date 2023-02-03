using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class BoolData : ScriptableObject
{
    public bool isOn = false;

    public void TurnOn()
    {
        isOn = true;
    }
    
    public void TurnOff()
    {
        isOn = false;
    }
}
