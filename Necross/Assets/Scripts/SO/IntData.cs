using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class IntData : ScriptableObject
{
    public int value;
    public int start = 0;

    public void Increase(int amount)
    {
        value += amount;
    }

    public void Decrease(IntData amount)
    {
        var newNum = amount.value;

        value -= newNum;
    }
    
    public void reset()
    {
        value = start;
    }
}
