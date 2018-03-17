using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camerafallow : MonoBehaviour {
    public Transform target;
    public float smoothTime = 0.001F;
    private Vector3 velocity = Vector3.zero;
    private static Vector3 rotation = Vector3.zero;
    private float xOffset = 1;
    private float yOffset = 1.5f;
    private float zOffset = -2;
    private GameObject player;
    // Use this for initialization
    void Start () {
        player = GameObject.FindWithTag("Player");
    }
	
	// Update is called once per frame
	void Update () {

        // Used this early on to just point the camera at the player at all time
        //transform.LookAt((target));


        //Determine angle to face based on direction of player

        //Get y angle of player
        float yRotation = player.transform.eulerAngles.y;
       
        //set rotation of camera to player direction


        if(rotation.y > yRotation)
        {
            transform.Rotate(0,1,0);
        }else if (rotation.y < yRotation)
        {
            transform.Rotate(0,-1,0);
        }


 

        Vector3 targetPosition = target.TransformPoint(new Vector3(0+xOffset, 0+yOffset, 0+zOffset));

        //this doesnt seem to work
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
       
    }
}
