using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game_Manager : MonoBehaviour
{

    bool gameEnded = false;

    public float delay = 1f;

    public GameObject completelevelUI;

    public void CompleteLevel()
    {
        completelevelUI.SetActive(true);
    }

    public void EndGame()
    {
        if (gameEnded == false)
        {
            gameEnded = true;
            Invoke("Restart", delay);
        }
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }



}
