// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class ObstacleSpawnerScript : MonoBehaviour
// {
//     public Transform[] SpawnPoints;
//     public List<GameObject> AllObstacles;
//     public GameObject Obstacle;
//     public GameObject newObstacleGO;
//     public int randomIndex;

//     public void Initialize()
//     {
//         AllObstacles = new List<GameObject>();
//     }

//     public void Process()
//     {
//         List<GameObject> obstaclesToBeDestroyed = new List<GameObject>();        

//         for(int i = 0; i < AllObstacles.Count; i++)
//         {
//             Vector3 obstacleTranform = AllObstacles[i].transform.position;
//             obstacleTranform.z -= 10 *Time.deltaTime;
//             AllObstacles[i].transform.position = obstacleTranform;
        

//             if(AllObstacles[i].transform.position.z <= -10.0f)
//             {
//                 obstaclesToBeDestroyed.Add(AllObstacles[i]);
//             }
//         }


//         for(int i = 0; i < obstaclesToBeDestroyed.Count; i++)
//         {
//             AllObstacles.Remove(obstaclesToBeDestroyed[i]);
//             GameObject.Destroy(obstaclesToBeDestroyed[i]);
//         }

//         obstaclesToBeDestroyed.Clear();
//     }

//     public void SpawnObstacles()
//     {
//         randomIndex = Random.Range(0, SpawnPoints.Length);

//         for(int i = 0; i < SpawnPoints.Length; i++)
//         {
//             if(randomIndex != i)
//             {
//                 newObstacleGO = (GameObject) Instantiate(Obstacle, SpawnPoints[i].position, Quaternion.identity);
//                 AllObstacles.Add(newObstacleGO);
//             }
//         }
//     }
// }