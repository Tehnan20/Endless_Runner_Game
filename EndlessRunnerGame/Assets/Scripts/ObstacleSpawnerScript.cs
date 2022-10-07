using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawnerScript : MonoBehaviour
{
    public Transform[] SpawnPoints;
    public List<GameObject> AllObstacles;
    public GameObject Obstacle;
    public Transform Player;
    public GameObject newObstacleGO;
    private float TimeToSpawn = 2f;
    public float TimeBetweenWaves = 5f;


    // public void Start()
    // {
    //     // StartCoroutine(SpawnObstacles());
    //    // StartCoroutine(updateTheFog());
    // }

    public void Initialize()
    {
        AllObstacles = new List<GameObject>();
    }

    public void Process()
    {
        List<GameObject> obstaclesToBeDestroyed = new List<GameObject>();        

        for(int i = 0; i < AllObstacles.Count; i++)
        {
            Vector3 obstacleTranform = AllObstacles[i].transform.position;
            obstacleTranform.z -= 10 *Time.deltaTime;
            AllObstacles[i].transform.position = obstacleTranform;
        

            if(AllObstacles[i].transform.position.z <= -20.0f)
            {
                obstaclesToBeDestroyed.Add(AllObstacles[i]);
            }
        }

        for(int i = 0; i < obstaclesToBeDestroyed.Count; i++)
        {
            AllObstacles.Remove(obstaclesToBeDestroyed[i]);
            GameObject.Destroy(obstaclesToBeDestroyed[i]);
        }

        obstaclesToBeDestroyed.Clear();

        if(Time.time >= TimeToSpawn)
        {
            SpawnObstacles();
            TimeToSpawn = Time.time + TimeBetweenWaves;
        }

    }

    public void SpawnObstacles()
    {
        int randomIndex = Random.Range(0, SpawnPoints.Length);

        for(int i = 0; i < SpawnPoints.Length; i++)
        {
            if(randomIndex != i)
            {
                newObstacleGO = (GameObject) Instantiate(Obstacle, SpawnPoints[i].position, Quaternion.identity);
                AllObstacles.Add(newObstacleGO);
                // newObstacleGO.GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, -10), ForceMode.VelocityChange);
            }
        }
    }

    // void Awake()
    // {
    //     allObstacles = new List<GameObject>();
    // }

    // void Update()
    // {
    //     for(int i = 0; i < allObstacles.Count; i++)
    //     {
    //         Vector3 obstacleTranform = allObstacles[i].transform.position;
    //         obstacleTranform.z -= 10 *Time.deltaTime;
    //         allObstacles[i].transform.position = obstacleTranform;
    //     }

    // }

    // public IEnumerator updateTheFog() 
    // {
    //     while(true)
    //     { 
    //         yield return new WaitForSeconds(1); 

    //         RenderSettings.fogDensity += 0.0015f;
    //     }
    // }

    // public IEnumerator SpawnObstacles()
    // {
    //     Debug.Log("SpawnObstacles");
    //     while(true)
    //     { 
    //         int randomIndex = Random.Range(0, SpawnPoints.Length);
    //         for(int i = 0; i < SpawnPoints.Length; i++)
    //         {
    //             if(randomIndex != i)
    //             {
    //                 newObstacleGO = (GameObject) Instantiate(Obstacle, SpawnPoints[i].position, Quaternion.identity);
    //                 newObstacleGO.GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, -10), ForceMode.VelocityChange);
    //             }
    //         }
    //         // yield return new WaitForSeconds(TimeBetweenWaves);
    //         yield return new WaitForSeconds(TimeBetweenWaves);
    //     }
    // }
}