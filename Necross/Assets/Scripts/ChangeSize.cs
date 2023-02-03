using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSize : MonoBehaviour
{
    public FloatData size;
    private Vector3 scale;
    private void Update()
    {
        scale.y = size.value;
        scale.x = size.value;
        this.transform.localScale = scale;
    }
}
