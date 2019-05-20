using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockDestroyer : MonoBehaviour
{
    void Start()
    {
        InvokeRepeating("Destroy", 3, 3); // Opakuj co 3 sekundy funkci Destroy
    }

    void Destroy()
    {
        Destroy(gameObject); // Znič kostku (Block)
    }
}
