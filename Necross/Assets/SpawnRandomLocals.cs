using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnRandomLocals : MonoBehaviour
{
    public List<GameObject> locations;
    public GameObject spawnLoc;

    public GameObject prefab;

    private void Update()
    {
        Spawn();
    }

    private void Spawn()
    {
        var value = Random.Range(0,locations.Capacity);
        spawnLoc = locations[value];
        Instantiate(prefab, spawnLoc.transform.position, Quaternion.identity);
        this.gameObject.SetActive(false);
    }
}
