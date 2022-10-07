using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameHUDViewScript : ViewScript
{
    public Text ScoreText;

    public ObstacleSpawnerScript ObstacleSpawner;
    public PlayerScript Player;
    
    public override void OnInitialize()
    {
        base.OnInitialize();
        Manager.MainViewHighScoreText.text = "Highscore : " + PlayerPrefs.GetInt("HighScore", 0).ToString();
        Manager.GameOverHighScoreText.text = "Highscore : " + PlayerPrefs.GetInt("HighScore", 0).ToString();
    
        Player.Initialize(Manager, View);
        ObstacleSpawner.Initialize();
    }

    public override void OnStart()
    {
        base.OnStart();
    }

    public override void OnUpdate()
    {
        base.OnUpdate();
        if(Manager.GameStarted == true)
        {
            ObstacleSpawner.Process();

            Player.Process();

            ScoreText.text = (Time.time * 2).ToString("0");
            if(int.Parse(ScoreText.text) > PlayerPrefs.GetInt("HighScore", 0))
            {
                PlayerPrefs.SetInt("HighScore", int.Parse(ScoreText.text));
            }
        }

        else
        {
            ScoreText.text = "GAME-OVER";
        }
    }
}
