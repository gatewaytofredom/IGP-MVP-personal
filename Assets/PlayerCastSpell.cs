using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCastSpell : MonoBehaviour {

    private GameObject player;
    private float deltaRotation;


    // Use this for initialization
    void Start () {
        player = GameObject.FindWithTag("Player");
        
    }
	
	// Update is called once per frame
	void Update () {

        //transform
        deltaRotation = player.transform.rotation.x - transform.rotation.x;
        transform.Rotate(0,deltaRotation,0);
       // transform.position.Set(player.transform.position.x, player.transform.position.y, player.transform.position.z);


    }
}
