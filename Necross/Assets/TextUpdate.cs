using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TextUpdate : MonoBehaviour
{
    public TextMeshProUGUI info;
    public IntData intD;
    public int amount;
    public IntData soulCount;

    public TextMeshProUGUI colorEx;

    private void Update()
    {
        if (amount <= soulCount.value)
        {
            info.color = colorEx.color;
        }
        if (intD.value == -2)
        {
            info.text = amount.ToString();  
        }
        else
        {
            info.text = intD.value.ToString();   
        }
    }
}
