using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObstaclesScript : MonoBehaviour
{
    void OnTriggerEnter(Collider col)
    {
        Destroy(col.gameObject, 1);
    }
    // void OnTriggerEnter(Collider col)
    // {
    //     Debug.Log("OnTriggerEnter");
    //     col.gameObject.SetActive(false);
    // }
}
