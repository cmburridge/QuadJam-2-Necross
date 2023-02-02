using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateEvent : MonoBehaviour
{
    public GameObject prefab;
    public FloatData time;

    public void StartSpawning()
    {
        StartCoroutine(SpawnMulitple());
    }

    public IEnumerator SpawnMulitple()
    {
        yield return new WaitForSeconds(time.value);
        Instantiate(prefab, this.transform.position, Quaternion.identity);
        yield return new WaitForSeconds(time.value);
        Instantiate(prefab, this.transform.position, Quaternion.identity);
        yield return new WaitForSeconds(time.value);
        Instantiate(prefab, this.transform.position, Quaternion.identity);
        yield return new WaitForSeconds(time.value);
        Instantiate(prefab, this.transform.position, Quaternion.identity);
        yield return new WaitForSeconds(time.value);
        Instantiate(prefab, this.transform.position, Quaternion.identity);
        yield return new WaitForSeconds(time.value);
        Instantiate(prefab, this.transform.position, Quaternion.identity);
        yield return new WaitForSeconds(time.value);
        Instantiate(prefab, this.transform.position, Quaternion.identity);
        yield return new WaitForSeconds(time.value);
        Instantiate(prefab, this.transform.position, Quaternion.identity);
        yield return new WaitForSeconds(time.value);
        Instantiate(prefab, this.transform.position, Quaternion.identity);
        yield return new WaitForSeconds(time.value);
        Instantiate(prefab, this.transform.position, Quaternion.identity);
        
    }

    public void SpawnObject()
    {
        Instantiate(prefab, this.transform.position, Quaternion.identity);
    }
}
