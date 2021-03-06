﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 if - podmínka napr. pokud x se rovná 5 tak udělej...
 void - funckce
 class - třída s metodama a proměnýma
 public - veřejná funckce, třida nebo proměná. Dá se k ní přistoupit z jiných tříd.
 using - import sady nějakých funkcí...
 Update - název funkce od Unity. Cyklus který se opakuje až do vypnutí programu.
 Start - název funkce od Unity. Při vytvoření daného objektu ve scéně.
 OnCollisionEnter - název funkce od Unity. Pří dotyku s objektem.
*/

public class BlockSpawner : MonoBehaviour
{
    public GameObject obstacle; // Kostka
    private float delay = 0.2f; // Zpoždění (0,2 s)

    void Start()
    {
        InvokeRepeating("Spawn", delay, delay); // Co 0,2 sekundy opakuj funkci Spawn
    }

    void Spawn() {
        Instantiate(obstacle, new Vector3(Random.Range(-12, 12), 10, 0), Quaternion.identity); /* Vytvoř kostku na náhodné Xové pozici od -10 až po 10 ve vyšce 10 (Y) a hloubce 0 (Z) */ /* Vector3, protože pracujeme ve 3D */
    }
}