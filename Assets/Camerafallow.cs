using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camerafallow : MonoBehaviour {
    public Transform target;

    private float xOffset = 2;
    private float yOffset = 1.5f;
    private float zOffset = -3;
 
    // Use this for initialization
    void Start () {
    }
	
	// Update is called once per frame
	void Update () {
        transform.position.Set(transform.position.x + xOffset,
            transform.position.y + yOffset, 
            transform.position.z + zOffset);
    }
}
