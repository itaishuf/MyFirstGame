using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class End_Trigger : MonoBehaviour
{

    public Game_Manager gameManager;


    void OnTriggerEnter()
    {
        gameManager.CompleteLevel();
    }
}
