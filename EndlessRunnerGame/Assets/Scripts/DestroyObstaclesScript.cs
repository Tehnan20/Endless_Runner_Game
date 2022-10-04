using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObstaclesScript : MonoBehaviour
{
    void OnTriggerEnter(Collider col)
    {
        FindObjectOfType<ObstacleSpawnerScript>().allObstacles.Remove(col.gameObject);
        Destroy(col.gameObject, 1f);
    }
}
