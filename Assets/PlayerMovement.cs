using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    // Use this for initialization
    float playerX = 0;
    float playerY = 0;
    void Start () {
 
}
	
	// Update is called once per frame
	void Update () {
        float x = -(Input.GetAxis("Mouse X")/2);
        float y = Input.GetAxis("Mouse Y")/2;

        playerX = playerX + x/2;
        playerY = playerY + y/2;

        transform.position = new Vector3(playerX,playerY,0);
    }
}
