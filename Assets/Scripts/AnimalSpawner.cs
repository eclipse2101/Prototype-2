using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalSpawner : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    float SpawnRangeX = 20;
    float spawnPosZ = 35;
    public float startingSpawn = 5; 
    public float spawnTiming = 1.5f;
    
    
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startingSpawn, spawnTiming);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnRandomAnimal()

    {
        
        Vector3 spawnPos = new Vector3(Random.Range(-SpawnRangeX, SpawnRangeX), 0, spawnPosZ); 
            
            int animalIndex = Random.Range(0, animalPrefabs.Length); 
            
            Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);

    }
}
