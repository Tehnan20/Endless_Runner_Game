﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawnerScript : MonoBehaviour
{
    public Transform[] SpawnPoints;
    public GameObject Obstacle;
    public Transform Player;
    public GameObject newObstacleGO;
    private float TimeToSpawn = 2f;
    public float TimeBetweenWaves = 5f;
    public bool isGameOver = true;

    void FixedUpdate()
    {
        if(Time.time >= TimeToSpawn)
        {
            SpawnObstacles();
            TimeToSpawn = Time.time + TimeBetweenWaves;
            transform.position -= transform.forward * Time.deltaTime;
        }

        if(Player.position.y < 0.75)
        {
            isGameOver = false;
        }
    }

    public void SpawnObstacles()
    {
        int randomIndex = Random.Range(0, SpawnPoints.Length);

        for(int i = 0; i < SpawnPoints.Length; i++)
        {
            if(randomIndex != i && isGameOver != false)
            {
                newObstacleGO = (GameObject) Instantiate(Obstacle, SpawnPoints[i].position, Quaternion.identity);
                newObstacleGO.GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, -10), ForceMode.VelocityChange);

                // Vector3 obstacleTranform = newObstacleGO.transform.position;
                // obstacleTranform.z -= 100 *Time.deltaTime;
                // newObstacleGO.transform.position = obstacleTranform;
            }
        }
    }
}
