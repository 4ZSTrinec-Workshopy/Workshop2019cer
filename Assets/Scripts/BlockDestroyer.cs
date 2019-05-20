using System.Collections;
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

public class BlockDestroyer : MonoBehaviour
{
    void Start() // Při vytvoření objektu proved'...
    {
        InvokeRepeating("Destroy", 3, 3); // Opakuj co 3 sekundy funkci Destroy
    }

    void Destroy() // Funkce co se bude opakovat každé 3 sekundy
    {
        Destroy(gameObject); // Znič kostku (Block)
    }
}
