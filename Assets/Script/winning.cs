using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class winning : MonoBehaviour {

    public GameObject gameOver;
    void Update ()
    {
        Debug.Log(House.score);
        if (House.score >= 1900)
        {
            gameOver.SetActive(true);
        }

    }
    public void retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
