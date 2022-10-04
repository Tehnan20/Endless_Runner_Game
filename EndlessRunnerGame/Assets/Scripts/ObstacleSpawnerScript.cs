using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawnerScript : MonoBehaviour
{
    public Transform[] SpawnPoints;
    public List<GameObject> allObstacles;
    public GameObject Obstacle;
    public Transform Player;
    public GameObject newObstacleGO;
    private float TimeToSpawn = 2f;
    public float TimeBetweenWaves = 5f;


    public void Start()
    {
        // StartCoroutine(SpawnObstacles());
        StartCoroutine(updateTheFog());
    }
    void FixedUpdate()
    {
        if(GameManagerScript.Instance.IsGameOver == false)
        {
            if(Time.time >= TimeToSpawn)
            {
                SpawnObstacles();
                TimeToSpawn = Time.time + TimeBetweenWaves;

                // Debug.Log("Testing Time Interval Between Spawning : " + TimeToSpawn + " : Current Time : " + Time.time);
                // transform.position -= transform.forward * Time.deltaTime;
            }

            if(Player.position.y < 0.75)
            {
                GameManagerScript.Instance.IsGameOver = true;
            }
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
                allObstacles.Add(newObstacleGO);
                // newObstacleGO.GetComponent<Rigidbody>().AddForce(new Vector3(0, 0, -10), ForceMode.VelocityChange);
            }
        }
    }

    void Awake()
    {
        allObstacles = new List<GameObject>();
    }

    void Update()
    {
        for(int i = 0; i < allObstacles.Count; i++)
        {
            Vector3 obstacleTranform = allObstacles[i].transform.position;
            obstacleTranform.z -= 10 *Time.deltaTime;
            allObstacles[i].transform.position = obstacleTranform;
        }

    }

    public IEnumerator updateTheFog() 
    {
        while(true)
        { 
            //this makes the loop itself yield 
            yield return new WaitForSeconds(1); 

            RenderSettings.fogDensity += 0.0015f;
        }
    }

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