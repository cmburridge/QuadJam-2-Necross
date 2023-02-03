using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class InstantiateEvent : MonoBehaviour
{
    public GameObject prefab;
    public FloatData time;
    public bool isCrypt = false;
    public bool isBoostedAI = false;
    public BoolData isON;
    public float timer;
    public float timerMax;

    public int amountToSpawn;

    public IntData randomMax;

    private void Update()
    {
        if (isON == true)
        {
            isBoostedAI = true;
        }
        
        timer -= 1 * Time.deltaTime;
        
        if (isCrypt == true && timer <= 0)
        {
            SpawnObject();
            timer = timerMax;
        }
    }

    public void StartSpawning()
    {
        StartCoroutine(SpawnMulitple());
    }

    public IEnumerator SpawnMulitple()
    {
        for (int i = 0; i < amountToSpawn; i++)
        {
            yield return new WaitForSeconds(time.value);
            Instantiate(prefab, this.transform.position, Quaternion.identity);  
        }
    }

    public void SpawnObject()
    {
        if (isBoostedAI == true)
        {
            Instantiate(prefab, this.transform.position, Quaternion.identity);
            if (randomMax.value <= 3)
            {
                randomMax.value = 3;
            }
            float num = Random.Range(1, randomMax.value);
            if (num == 2)
            {
                Instantiate(prefab, this.transform.position, Quaternion.identity);
                Instantiate(prefab, this.transform.position, Quaternion.identity);
            }
        }
        else
        {
            Instantiate(prefab, this.transform.position, Quaternion.identity);  
        }
    }
}
