using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCons : MonoBehaviour
{
    public GameObject ui;
    
    private void Start()
    {
        ui.SetActive(false);
    }

    void Update()
    {
        this.transform.Rotate(0,0,25 * Time.deltaTime);
    }
}
