using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class RandomMove : MonoBehaviour
{
    public float wanderRadius = 0;
    public float wanderSpeed = 0;
    public float wanderTimer = 0;

    private Vector3 targetPosition;
    private float timer;

    public GameObject center;

    public bool reCenter = false;

    private void Start()
    {
        wanderRadius = Random.Range(5, 15);
        wanderSpeed = Random.Range(1, 2);
        wanderTimer = Random.Range(5, 15);
            
        targetPosition = transform.position;
        timer = wanderTimer;
    }

    private void Update()
    {
        timer += Time.deltaTime;

        if (reCenter == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, center.transform.position, wanderSpeed * Time.deltaTime);
        }
        
        if (timer >= wanderTimer)
        {
            targetPosition = transform.position + Random.insideUnitSphere * wanderRadius;
            timer = 0;
        }

        transform.position = Vector3.MoveTowards(transform.position, targetPosition, wanderSpeed * Time.deltaTime);
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        reCenter = false;
    }

    public void reverseDirection()
    {
        reCenter = true;
    }
}
