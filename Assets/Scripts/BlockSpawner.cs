using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSpawner : MonoBehaviour
{
    public GameObject obstacle; // Kostka
    private float delay = 0.2f; 

    void Start()
    {
        InvokeRepeating("Spawn", delay, delay); // Co 0,2 sekundy opakuj funkci Spawn
    }

    void Spawn() {
        Instantiate(obstacle, new Vector3(Random.Range(-10, 10), 10, 0), Quaternion.identity); /* Vytvoř kostku na náhodné Xové pozici od -10 až po 10 ve vyšce 10 (Y) a hloubce 0 (Z) */ /* Vector3, protože pracujeme ve 3D */
    }
}