using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgIns : MonoBehaviour
{
    public GameObject g;
    public GameObject genPnt;
    private Vector3 gWidth;

    private void Start()
    {
        gWidth = g.GetComponent<Renderer>().bounds.size;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < genPnt.transform.position.x)
        {
            transform.position = new Vector3(transform.position.x + gWidth.x, transform.position.y, transform.position.z);
            Instantiate(g, transform.position, transform.rotation);

        }  // Debug.Log("dgfdhg");
    }

}
