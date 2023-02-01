using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateEvent : MonoBehaviour
{
    public GameObject prefab;
    
    public void SpawnObject()
    {
        Instantiate(prefab, this.transform.position, Quaternion.identity);
    }
}
