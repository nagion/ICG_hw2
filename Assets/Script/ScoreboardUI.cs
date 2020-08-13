using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreboardUI : MonoBehaviour {

    public Text scoreText;

    void Update()
    {

        scoreText.text = "Score:" + House.score.ToString();
    }
}
