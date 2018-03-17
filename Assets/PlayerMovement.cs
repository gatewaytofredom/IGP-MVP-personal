using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    // Use this for initialization
    float playerX = 0;
    float playerY = 0;
    float playerZ = 0;

    float playerRotation = 180;
    float playerTranslation = 0;

    private GameObject Player;
    void Start () {
        Player = GameObject.FindWithTag("Player");
    }
	
	// Update is called once per frame
	void Update () {
        playerTranslation *= Time.deltaTime;
        playerRotation *= Time.deltaTime;
        if (Input.GetAxis("Horizontal") > 0)
        {
            playerRotation += 2f;
        }else if (Input.GetAxis("Horizontal") < 0)
        {
            playerRotation -= 2f;
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

      // transform.position = new Vector3();
        transform.Rotate(0,playerRotation,0);
    }
}
