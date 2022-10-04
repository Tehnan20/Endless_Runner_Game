using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScoreScript : MonoBehaviour
{
    public Text ScoreText;
    // Update is called once per frame
    void Update()
    {
        if(FindObjectOfType<ObstacleSpawnerScript>().isGameOver == true)
        {
            ScoreText.text = (Time.time *2).ToString("0");
        }
        else if(FindObjectOfType<ObstacleSpawnerScript>().isGameOver == false)
        {
            ScoreText.text = "GAME-OVER";
        }
    }
}
