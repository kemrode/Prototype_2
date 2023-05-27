using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;

    private float spawnRangeX = 20.0f;
    private float spawnPsoZ = 20.0f;

    private float spawnRangeZ = 20.0f;
    private float spawnPsoX = 10f;

    private GameObject newAnimalToSpawn;
    private float startDelay = 2.0f;
    private float spawnInterval = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
        InvokeRepeating("SpawnVerticalLeftAnimals", startDelay + 1, spawnInterval);
        InvokeRepeating("SpawnVerticalRightAnimals", startDelay + 2, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    { 
    }

    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        float randomXRespawnPosition = Random.Range(-spawnRangeX, spawnRangeX);
        Vector3 respawnPosition = new Vector3(randomXRespawnPosition, 0, spawnPsoZ);
        newAnimalToSpawn = animalPrefabs[animalIndex];


        Instantiate(newAnimalToSpawn, respawnPosition, newAnimalToSpawn.transform.rotation);
    }

    void SpawnVerticalLeftAnimals()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        float randomZRespawnPosition = Random.Range(10, spawnRangeZ);
        Vector3 respawnPosition = new Vector3(-25, 0, randomZRespawnPosition);
        newAnimalToSpawn = animalPrefabs[animalIndex];

        Instantiate(newAnimalToSpawn, respawnPosition, Quaternion.Euler(0, 90, 0));
    }

    void SpawnVerticalRightAnimals()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        float randomZRespawnPosition = Random.Range(10, spawnRangeZ);
        Vector3 respawnPosition = new Vector3(25, 0, randomZRespawnPosition);
        newAnimalToSpawn = animalPrefabs[animalIndex];

        Instantiate(newAnimalToSpawn, respawnPosition, Quaternion.Euler(0, -90, 0));
    }
}
