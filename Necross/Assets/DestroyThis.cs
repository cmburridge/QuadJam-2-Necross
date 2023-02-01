using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyThis : MonoBehaviour
{
    public float deathTimer;

    public void DestroyObject()
    {
        StartCoroutine(DestroyTimed());
    }

    IEnumerator DestroyTimed()
    {
        yield return new WaitForSeconds(deathTimer);
        Destroy(this.gameObject);
    }
}
