using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    // Rangos del intervalo aleatorio
    private float minSpawnInterval = 3.0f;
    private float maxSpawnInterval = 5.0f;

     private float startDelay = 1.0f; // Podemos usar un valor fijo la primera vez
    // private float spawnInterval = 4.0f; // Borramos o comentamos esta variable

    // Start is called before the first frame update
    void Start()
    {
        //InvokeRepeating("SpawnRandomBall", startDelay, spawnInterval); // Antes
        Invoke("SpawnRandomBall", startDelay); // Despues  (Usando primer delay fijo)
        //Invoke("SpawnRandomBall", Random.Range(minSpawnInterval,maxSpawnInterval)); //  (Sin primer delay fijo)
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        int indexBall = Random.Range(0,ballPrefabs.Length);
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[indexBall], spawnPos, ballPrefabs[0].transform.rotation);

        float interval = Random.Range(minSpawnInterval, maxSpawnInterval);
        Invoke("SpawnRandomBall", interval);
    }

}
