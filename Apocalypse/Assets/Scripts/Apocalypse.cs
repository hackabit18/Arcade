using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Apocalypse : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void Chapter()
    {
        SceneManager.LoadScene("Chapters_scene");
    }
    public void Forest()
    {
        SceneManager.LoadScene("Menu_scene");

    }
    public void City()
    {
        SceneManager.LoadScene("City_scene");

    }


}
