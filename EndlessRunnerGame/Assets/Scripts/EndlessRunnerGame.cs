using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndlessRunnerGame : MonoBehaviour
{
    // public Transform Gun;
    // public float YForce;
    // public float ZForce;
    // public int listIndex = 0;
    // public List<GameObject> Bullets;
    
    public Rigidbody PlayerRB;
    public Transform Player;
    public Vector3 Offset;

    // void Start()
    // {
    //     for(int i = 0; i < 4; i++)
    //     {
    //         Bullets[i].SetActive(false);
    //     }
    // }
    void Update()
    {
        if(GameManagerScript.Instance.IsGameOver == false)
        {
            transform.position = Player.position + Offset;   
        }
    }
    
    void FixedUpdate()
    {
        if(GameManagerScript.Instance.IsGameOver == false)
        {
            if (Input.GetKey(KeyCode.A))
            {
                Vector3 newPos = new Vector3(-70 *Time.deltaTime, 0, 0);
                PlayerRB.AddForce(newPos, ForceMode.VelocityChange);
            }

            if (Input.GetKey(KeyCode.D))
            {
                Vector3 newPos = new Vector3(70 *Time.deltaTime, 0, 0);
                PlayerRB.AddForce(newPos, ForceMode.VelocityChange);
            }
        }

        // if (Input.GetKeyDown(KeyCode.Space))
        // {
        //     Debug.Log("Bullets-Count : " + Bullets.Count);
            
        //         Bullets[listIndex].GetComponent<Transform>().localPosition = new Vector3(Gun.position.x, Gun.position.y + 0.13f, Gun.position.z + 2.1f);
        //         Bullets[listIndex].SetActive(true);
        //         Bullets[listIndex].GetComponent<Rigidbody>().AddForce(new Vector3(0, YForce, ZForce));
        //         listIndex++;

        //     if(listIndex >= Bullets.Count)
        //     {
        //         listIndex = 0;
        //     }
        // }
    }
}
