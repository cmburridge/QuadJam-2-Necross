using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DestroyThis : MonoBehaviour
{
    public float deathTimer;
    public GameObject controller;
    public FloatData portalTimer;
    public UnityEvent unSpawn;

    public bool isPortal = false;
    
    public UnityEvent startEvent;
    
    public void Start()
    {
        if (isPortal == true)
        {
            deathTimer = portalTimer.value;
        }
       
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
        unSpawn.Invoke();
        Destroy(controller);
    }
}
