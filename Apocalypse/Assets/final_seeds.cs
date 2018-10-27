using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class final_seeds : MonoBehaviour {
    public Text Final_Score_text;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Final_Score_text.text = PlayerPrefs.GetString("finalcount");
	}
}
