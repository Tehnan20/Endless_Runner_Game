﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndlessRunnerGame : MonoBehaviour
{    
    public Rigidbody PlayerRB;
    public Transform Player;
    public Vector3 Offset;
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
                Vector3 newPos = new Vector3(-60 *Time.deltaTime, 0, 0);
                PlayerRB.AddForce(newPos, ForceMode.VelocityChange);
            }

            if (Input.GetKey(KeyCode.D))
            {
                Vector3 newPos = new Vector3(60 *Time.deltaTime, 0, 0);
                PlayerRB.AddForce(newPos, ForceMode.VelocityChange);
            }
        }
    }
}
