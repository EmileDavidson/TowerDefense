using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowSpawner : MonoBehaviour
{
    public GameObject arrowObj;
    private void Start()
    {
        StartCoroutine(spawn());
    }

    public IEnumerator spawn()
    {
        Instantiate(arrowObj);
        yield return new WaitForSeconds(5);
        Instantiate(arrowObj);
        yield return new WaitForSeconds(5);
        Instantiate(arrowObj);
        yield return new WaitForSeconds(5);
        Instantiate(arrowObj);
        yield return new WaitForSeconds(5);
        Instantiate(arrowObj);
        
        Destroy(this);
        yield return null;
    }
}
