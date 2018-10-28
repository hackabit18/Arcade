using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Pause_panel_menu : MonoBehaviour
{

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
    public void MainMenu()
    {
        if(Time.timeScale == 0)
        {
            Time.timeScale = 1;
        }
        SceneManager.LoadScene("Chapters_scene");
    }
    public void Restart()
    {

        SceneManager.LoadScene("Menu_scene");
    }
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Pause()
    {
        // (Time.timeScale == 1)
        Time.timeScale = 0;

    }
    public void Resume()
    {
        // if (Time.timeScale == 0)
        { Time.timeScale = 1; }
    }
}
