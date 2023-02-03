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

    public TextMeshProUGUI colorBlue;
    public TextMeshProUGUI colorRed;

    public GameObject button;
    public GameObject text;
    public bool canBuy = true;

    private void Update()
    {
        if (canBuy == false)
        {
            button.SetActive(false);
            text.SetActive(false);
        }
        else
        {
            button.SetActive(true);
        }
        
        if (amount <= soulCount.value)
        {
            canBuy = true;
            info.color = colorBlue.color;
        }
        else if (amount >= soulCount.value)
        {
            canBuy = false;
            info.color = colorRed.color;
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
