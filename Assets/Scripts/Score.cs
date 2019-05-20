using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    int score = 0;
    Text scoreText;

    void Start()
    {
        InvokeRepeating("IncrementScore", 0, 1);
        scoreText = this.GetComponent<Text>();
    }

    void IncrementScore() {
        score++;
        scoreText.text = "Score: " + score;
    }
}
