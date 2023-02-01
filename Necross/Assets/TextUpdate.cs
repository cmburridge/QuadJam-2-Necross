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

    private void Update()
    {
       info.text = intD.value.ToString();
    }
}
