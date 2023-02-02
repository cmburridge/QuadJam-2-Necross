using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class IntData : ScriptableObject
{
    public int value;

    public void Increase(int amount)
    {
        value += amount;
    }

    public void Decrease(int amount)
    {
        if (value < amount)
        {
            return;
        }
        else if (value >= amount)
        {
            value -= amount;
        }
    }
}
