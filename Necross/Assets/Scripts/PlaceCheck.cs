using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class PlaceCheck : MonoBehaviour
{
    public BoolData canPlace;
    public IntData cost;
    public IntData souls;
    public Vector3 loc;

    public GameObject prefab;

    private void Start()
    {
        loc = this.transform.position;
        loc.y += 2;
        if (canPlace.isOn == false)
        {
            Instantiate(prefab, loc, quaternion.identity);
            souls.value += cost.value;
            Destroy(this.gameObject);
        }
    }
}
