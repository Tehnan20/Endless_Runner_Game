using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScoreScript : MonoBehaviour
{
    public Text ScoreText;
    void Update()
    {
        if(GameManagerScript.Instance.IsGameOver == false)
        {
            ScoreText.text = (Time.time *3).ToString("0");
        }

        else
        {
            ScoreText.text = "GAME-OVER";
        }
    }
}
