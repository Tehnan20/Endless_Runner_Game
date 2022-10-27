using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagerScript : MonoBehaviour
{
    // Singleton Code
    private static GameManagerScript _Instance = null;
    public static GameManagerScript Instance
    {
        get
        {
            if (_Instance == null)
            {
                _Instance = (GameManagerScript)FindObjectOfType(typeof(GameManagerScript));
            }

            return _Instance;
        }
    }

    public bool GameStarted;
    public Text MainViewHighScoreText;
    public Text GameOverHighScoreText;
    public ViewManagerScript ViewManager;
    public ECSManagerScript ECSManager;

    public void Awake()
    {
        Application.targetFrameRate = 60;
        ViewManager.Initialize();
    }

    public void Start()
    {
        ViewManager.Setup();
    }
    
    public void Update()
    {
        ViewManager.Process();
    }
}
