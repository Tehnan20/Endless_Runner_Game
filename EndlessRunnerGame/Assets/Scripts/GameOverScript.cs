using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScript : MonoBehaviour
{
    public void OnCollisionEnter(Collision col) {
        Debug.Log("bbbb" + col.collider.tag);
        if(col.collider.tag == "Obstacle")
        {
            FindObjectOfType<ObstacleSpawnerScript>().isGameOver = false;
        }
    }
}
