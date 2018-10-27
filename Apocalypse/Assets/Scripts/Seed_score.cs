using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Seed_score : MonoBehaviour
{
    int score;
    public Text Score_text;
    // Use this for initialization
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        score = GameObject.Find("Bolchie - Basic 1").GetComponent<Demo>().counter;
        Score_text.text = "Seeds: " + score.ToString();

    }
}
