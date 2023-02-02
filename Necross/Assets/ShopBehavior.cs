using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ShopBehavior : MonoBehaviour
{
   public ItemData myItem;
   public HeldItem held;

   private Sprite art;

   public GameObject artObj;
   private Vector3 target;

   public UnityEvent startEvent;

   private void Start()
   {
      startEvent.Invoke();
   }

   private void Update()
   {
      myItem = held.item;
      art = myItem.art;
      var ren = artObj.GetComponent<SpriteRenderer>();

      ren.sprite = art;

      target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
      target.z = transform.position.z;

      artObj.transform.position = Vector3.MoveTowards(transform.position, target, target.magnitude);

      if (Input.GetMouseButtonDown(1))
      {
         if (held.item == null)
         {
            startEvent.Invoke();
         }
         else
         {
            Instantiate(myItem.prefab, target, Quaternion.identity);
            startEvent.Invoke();  
         }
      }
   }
}
