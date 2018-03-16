using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCastSpell : MonoBehaviour {

    public Transform Cords;
    public Transform casterDirection;
    public float smoothTime = 0.001F;
    private Vector3 velocity = Vector3.zero;
    public Quaternion rotation = Quaternion.identity;
    private GameObject Player;

    // Use this for initialization
    void Start () {
        Player = GameObject.FindWithTag("Player");

    }
	
	// Update is called once per frame
	void Update () {

        transform

        transform.Rotate(-90,Player.transform.rotation.y,0);

    }
}
