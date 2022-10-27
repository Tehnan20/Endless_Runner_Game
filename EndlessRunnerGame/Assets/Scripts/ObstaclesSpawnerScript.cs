using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclesSpawnerScript : MonoBehaviour
{
    public List<GameObject> AllObstacleVariations;
    public List<GameObject> AllFalseObstacles;
    public GameObject ObstacleVariations;
    public Transform Player;
    private float TimeToSpawn = 2f;
    public float TimeBetweenWaves = 2f;
    private int RandomIndex;

    public void Initialize()
    {
        AllObstacleVariations = new List<GameObject>();

        for (int i = 0; i < ObstacleVariations.transform.childCount; i++)
        {
            GameObject obj = ObstacleVariations.transform.GetChild(i).gameObject;
            AllObstacleVariations.Add(obj);
            AllFalseObstacles.Add(obj);
        }

    }

    public void Process()
    {
        if(Time.time >= TimeToSpawn)
        {
            RandomIndex = Random.Range(0, AllFalseObstacles.Count);
            SpawnObstacles();
            TimeToSpawn = Time.time + TimeBetweenWaves;
        }


        for (int i = 0; i < AllObstacleVariations.Count; i++)
        {
            if(AllObstacleVariations[i].activeSelf == true)
            {
                Vector3 obstaclesTranform = AllObstacleVariations[i].transform.position;
                obstaclesTranform.z -= 10 *Time.deltaTime;
                AllObstacleVariations[i].transform.position = obstaclesTranform;
            }
        }

        for(int i = 0; i < AllObstacleVariations.Count; i++)
        {
            if(AllObstacleVariations[i].transform.position.z <= -5.0f)
            {
                AllObstacleVariations[i].SetActive(false);
                AllFalseObstacles.Add(AllObstacleVariations[i]);
                
                Vector3 obstaclesTranform = AllObstacleVariations[i].transform.position;
                obstaclesTranform.z = 45f;
                AllObstacleVariations[i].transform.position = obstaclesTranform;
            }
        }
    }

    public void SpawnObstacles()
    {        
        if(AllObstacleVariations[RandomIndex].activeSelf == false)
        {
            AllObstacleVariations[RandomIndex].SetActive(true);
            AllFalseObstacles.Remove(AllObstacleVariations[RandomIndex]);
            Debug.Log("Active Obstacle Variation : " + AllObstacleVariations[RandomIndex]);
        }
    }
}
