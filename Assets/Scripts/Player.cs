using System.Collections;
using System.Collections.Generic;
using UnityEngine; // Import třídy UnityEngine
using UnityEngine.SceneManagement; // Import třídy SceneManagement

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

public class Player : MonoBehaviour
{
    /*void Start()
    {
        transform.position = Vector3.right * 10;  
    }*/

    void Update() // Cyklus který se opakuje do vypnutí programu
    {
        if (Input.GetKey(KeyCode.A)) { // Když zmáčkneš klávesu A tak udělej ...
            transform.position += Vector3.left * 10 * Time.deltaTime; /* Pohni se do leva */ /* 10 Je rychlost, kdyby tam bylo 5 tak by se kostka (Block) pohybovalo poloviční rychlostí*/ 
                                                                      /* Zajistí, aby se kostka pohybovala za jaké koliv podmínky stejnou rychlostí, pokud to nebude nařízeno v kódu*/
        }
        else if (Input.GetKey(KeyCode.D)) /*To samé akorát pro klávesu D*/
        {
            transform.position += Vector3.right * 10 * Time.deltaTime; /* To samé akorát do prava */
        }
        if (transform.position.x >= 12.5) { // Když hrát chce opustit scénu tak...
            SceneManager.LoadScene("SampleScene"); // Restart
        }
        else if (transform.position.x <= -12.5) // Když hrát chce opustit scénu tak...
        {
            SceneManager.LoadScene("SampleScene"); // Restart
        }
    }

    void OnCollisionEnter(Collision collision) // Když se dotkneš objektu...
    {
        if (collision.collider.tag == "block") { // Při dotyku s objektem s tagem block
            SceneManager.LoadScene("SampleScene"); // Restartuj scénu
        }
    }
}