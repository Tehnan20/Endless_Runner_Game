using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{    
    public Rigidbody PlayerRB;
    public Transform Player;
    public Vector3 Offset;

    public float StrafeSpeed = 20;

    private GameManagerScript Manager;
    private ViewManagerScript View;

    public void Initialize(GameManagerScript manager, ViewManagerScript view)
    {
        Manager = manager;
        View = view;
        transform.position = Player.position + Offset;
    }

    public void Process()
    {
        if (Input.GetKey(KeyCode.A))
        {
            Vector3 newPos = new Vector3(-StrafeSpeed *Time.deltaTime, 0, 0);
            PlayerRB.AddForce(newPos, ForceMode.VelocityChange);
        }

        if (Input.GetKey(KeyCode.D))
        {
            Vector3 newPos = new Vector3(StrafeSpeed *Time.deltaTime, 0, 0);
            PlayerRB.AddForce(newPos, ForceMode.VelocityChange);
        }
    }

    public void OnCollisionEnter(Collision col) 
    {
        if(col.collider.tag == "Obstacle")
        {
            Debug.Log(col.collider.tag);
            Manager.GameStarted = false;
            View.Open("GameOverView");
            View.Close("GameHUDView");
        }

    //     if(Manager != null)
    //     {
    //         if(Manager.GameStarted == false)
    //         {
    //             View.Open("GameOverView");
    //             View.Close("GameHUDView");
    //         }
    //     }
    }
}
