using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camerafallow : MonoBehaviour {
    public Transform target;
    public float smoothTime = 0.001F;
    private Vector3 velocity = Vector3.zero;
    private int xOffset = 0;
    private int yOffset = -10;
    private int zOffset = 0;
    private float rotation = 0;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        transform.LookAt(target);


        Vector3 targetPosition = target.TransformPoint(new Vector3(0+xOffset, 5+yOffset, 0+zOffset));
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
       
    }
}
