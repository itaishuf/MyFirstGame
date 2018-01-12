using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    public PlayerControls movement;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag=="obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<Game_Manager>().EndGame();
        }
    }   

}
