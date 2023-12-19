using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] popcornPrefabs;

    private float spawnLimitXLeft = -6;
    private float spawnLimitXRight = 2; 
  
    private float spawnPosY = 10;

    private float startDelay = 1.0f;
    private float spawnInterval = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomPopcorn", startDelay, spawnInterval);
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomPopcorn ()
    {
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY,Random.Range(-4, 3));    
        
        int popcornIndex = Random.Range(0, popcornPrefabs.Length);
        // instantiate ball at random spawn location
        Instantiate(popcornPrefabs[popcornIndex], spawnPos, popcornPrefabs[popcornIndex].transform.rotation);
    }

}
