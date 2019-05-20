using System.Collections;
using System.Collections.Generic;
using UnityEngine; // Import třídy UnityEngine
using UnityEngine.SceneManagement; // Import třídy SceneManagement

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
    }

    private void OnCollisionEnter(Collision collision) // Když se dotkneš objektu...
    {
        if (collision.collider.tag == "block") { // Při dotyku s objektem s tagem block
            SceneManager.LoadScene("SampleScene"); // Restartuj scénu
        }
    }
}
