using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameHUDViewScript : ViewScript
{
    public Text ScoreText;
    public ObstaclesSpawnerScript ObstaclesSpawner;
    public PlayerScript Player;
    public float CurrentTime;
    public int StartMinutes;
    
    public override void OnInitialize()
    {
        base.OnInitialize();
        Manager.MainViewHighScoreText.text = "Highscore : " + PlayerPrefs.GetInt("HighScore", 0).ToString();
        Manager.GameOverHighScoreText.text = "Highscore : " + PlayerPrefs.GetInt("HighScore", 0).ToString();
    
        Player.Initialize(Manager, View);
        ObstaclesSpawner.Initialize();
        CurrentTime = StartMinutes * 60;
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
            ObstaclesSpawner.Process();

            Player.Process();

            CurrentTime = CurrentTime + Time.deltaTime *3;
            ScoreText.text = CurrentTime.ToString("0");

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
