using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class AudioControl : MonoBehaviour
{
    public AudioSource audSr;

    private void Start()
    {
        float num = Random.Range(1,10);
        if (num == 2)
        {
            return;
        }
        else
        {
            audSr.clip = null;
        }
    }
}
