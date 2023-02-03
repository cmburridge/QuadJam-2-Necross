using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnMouseMove : MonoBehaviour
{
    public float speed = 5;
    private Vector3 target;
    public BoolData canMove;

    public GameObject prefab;

    public GameObject text;

    private void Start()
    {
        target = transform.position;
    }

    private void Update()
    {
        if (canMove == true)
        {
            if (Input.GetMouseButtonDown(1))
            {
                text.SetActive(false);
                target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                target.z = transform.position.z;
                Instantiate(prefab, target, Quaternion.identity);
                target.y += 2;
            }
        
            transform.position = Vector3.Lerp(transform.position, target, speed * Time.deltaTime);   
        }
    }
}
