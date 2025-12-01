using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    private float timeToSpawn = 0.0f; // Registro de la proxima vez que se pueda invocar a un perro (Comienza en 0)
    private float coolDown = 1.0f; //Tiempo de espera para volver a llamar o invocar el perro.

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > timeToSpawn)
        {
            timeToSpawn = Time.time + coolDown; // Se actualiza la hora a la que puede aparecer un perro tomando el tiempo de nefriemaietnp.
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}
