using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SortArt : MonoBehaviour
{
    public SpriteRenderer sr;

    private void Update()
    {
        sr.sortingOrder = (int) (this.transform.position.y * -100);
    }
}
