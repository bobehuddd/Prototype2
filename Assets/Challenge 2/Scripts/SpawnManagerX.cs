using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 40; // memunculkan bola dari atas scene screen

    private float startDelay = 1.0f;
    private float spawnInterval = 4.0f;
    

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomBall", startDelay, spawnInterval);
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall()
{
    //Buat interval spawn menjadi nilai acak antara 3 detik dan 5 detik
    float randomSpawnInterval = Random.Range(3.0f, 5.0f);
    Invoke("SpawnRandomBall", randomSpawnInterval);
    
    // Buat bola 1, 2, dan 3 muncul secara acak
    int randomIndex = Random.Range(0, ballPrefabs.Length);
    Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);
    Instantiate(ballPrefabs[randomIndex], spawnPos, ballPrefabs[randomIndex].transform.rotation);
}

}
