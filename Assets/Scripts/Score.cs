using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    int score = 0; // Proměná score
    Text scoreText; // Text, který se bude zobrazovat na obrazovce

    void Start() // Při vytvoření objektu proved'...
    {
        InvokeRepeating("IncrementScore", 0, 1); // Co 1 sekundu opakuj...
        scoreText = this.GetComponent<Text>(); // Nastav scoreText na objekt s tímto skriptem
    }

    void IncrementScore() { // Funkce co se bude opakovat každou sekundu
        score++; // Přičti ke score 1
        scoreText.text = "Score: " + score; // Nastav, aby text zobrazoval hodnotu score
    }
}
