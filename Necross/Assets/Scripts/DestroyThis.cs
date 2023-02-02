using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DestroyThis : MonoBehaviour
{
    public float deathTimer;
    public GameObject controller;
    public UnityEvent startEvent;
    
    public void Start()
    {
       startEvent.Invoke();
    }

    public void DestroyObjectTimed()
    {
        StartCoroutine(DestroyTimed());
    }

    IEnumerator DestroyTimed()
    {
        yield return new WaitForSeconds(deathTimer);
        Destroy(this.gameObject);
    }

    public void DestroyAll()
    {
        Destroy(controller);
    }
}
