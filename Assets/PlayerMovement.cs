﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    // Use this for initialization
    float playerX = 0;
    float playerY = 0;
    float playerZ = 0;
    float playerRotation = 180;
    float playerTranslation = 0;
    void Start () {
 
}
	
	// Update is called once per frame
	void Update () {
        playerTranslation *= Time.deltaTime;
        playerRotation *= Time.deltaTime;
        if (Input.GetAxis("Horizontal") > 0)
        {
            playerRotation += 1.5f;
        }else if (Input.GetAxis("Horizontal") < 0)
        {
            playerRotation -= 1.5f;
        }


        if(Input.GetAxis("Vertical") > 0)
        {
            playerTranslation += 0.2f;
        }
        else if (Input.GetAxis("Vertical") < 0)
        {
            playerTranslation -= 0.2f;
        }



        // transform.position = new Vector3(playerX,0, playerZ);
        transform.Translate(0,0,playerTranslation);
        transform.Rotate(0,playerRotation,0);
    }
}
