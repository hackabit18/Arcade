using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect_bulb : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnCollisionEnter2D(Collision2D collider)
    {
        if(collider.gameObject.CompareTag("Player"))
        {
            Debug.Log("Bulb collected");
            Destroy(gameObject);
        }
    }
}
