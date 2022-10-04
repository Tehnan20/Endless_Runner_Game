﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScript : MonoBehaviour
{
    public void OnCollisionEnter(Collision col) {
        if(col.collider.tag == "Obstacle")
        {
            GameManagerScript.Instance.IsGameOver = true;
          //  FindObjectOfType<ObstacleSpawnerScript>().isGameOver = false;
        }
    }
}
