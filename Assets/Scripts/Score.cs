﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    public static int score = 0;
    public Text scoreText;
    public Text highScoreText;

    // Use this for initialization
    void Start()
    {
        highScoreText.text = "High Score: " + PlayerPrefs.GetInt("HighScore", 0).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = score.ToString();
        if (score > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", score);
            highScoreText.text = "High Score: " + score.ToString();
        }
    }

    public void ResetHighScore()
    {
        PlayerPrefs.DeleteKey("HighScore");
    }
}
