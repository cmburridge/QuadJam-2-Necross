using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MouseEvent : MonoBehaviour
{
    public UnityEvent MouseButtonDown;
    public UnityEvent MouseDown;
    public UnityEvent MouseOver;
    public UnityEvent MouseOff;
    public int mouseButton = 1;
    
    private void Update()
    {
        if (Input.GetMouseButtonDown(mouseButton))
        {
            MouseButtonDown.Invoke();
        }
    }

    private void OnMouseDown()
    {
        MouseDown.Invoke();
    }

    private void OnMouseEnter()
    {
        MouseOver.Invoke();
    }

    private void OnMouseExit()
    {
        MouseOff.Invoke();
    }
}
