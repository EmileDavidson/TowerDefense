using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eventFunctions : MonoBehaviour
{
    private Vector3 startPos;
    private void Start()
    {
        startPos = this.gameObject.transform.position;
    }

    public void destoryThisGameobject()
    {
        Destroy(this.gameObject);
    }
    
    public void resetPostition()
    {
        this.gameObject.transform.position = startPos;
    }
}
