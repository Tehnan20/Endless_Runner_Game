using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverViewScript : ViewScript
{
    public ViewManagerScript script;
    public void OnCollisionEnter(Collision col) 
    {
        if(col.collider.tag == "Obstacle")
        {
            Debug.Log(col.collider.tag);
            GameManagerScript.Instance.GameStarted = false;
        }

        if(GameManagerScript.Instance.GameStarted == false)
        {
            GameManagerScript.Instance.ViewManager.Open("GameOverView");
            GameManagerScript.Instance.ViewManager.Close("GameHUDView");
        }
    }
}
