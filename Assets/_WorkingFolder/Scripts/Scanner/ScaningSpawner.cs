using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaningSpawner : MonoBehaviour
{
    [Header("Spawn Settings")]
    [SerializeField] private GameObject ScanerToSpawn; 
    [SerializeField] private Transform spawnPosition; 
    [SerializeField] private float spawnInterval = 2f;  

    private void Start()
    {
        // Start the spawning coroutine
        StartCoroutine(SpawnPrefabAtInterval());
    }

    private IEnumerator SpawnPrefabAtInterval()
    {
        // Infinite loop to spawn objects at regular intervals
        while (true)
        {
            // Spawn the prefab at the specified position and rotation
            Instantiate(ScanerToSpawn, spawnPosition.position, spawnPosition.rotation);

            // Wait for the specified interval
            yield return new WaitForSeconds(spawnInterval);
        }
    }
}
