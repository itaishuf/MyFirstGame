using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour {

    public Rigidbody rb;

    public float Forward_Speed = 200f;
    public float Sideways_Speed = 500f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        rb.AddForce(0, 0, Forward_Speed * Time.deltaTime);

        if(Input.GetKey("d"))
        {
            rb.AddForce(Sideways_Speed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-Sideways_Speed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        
        if(rb.position.y<-1f)
        {
            FindObjectOfType<Game_Manager>().EndGame();
        }
    }
}
