using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBlade : MonoBehaviour
{
    public GameObject prefabToSpawn; // Reference to the prefab
    public float spawnInterval = 2.0f; // Time interval between spawns (in seconds)

    void Start()
    {
        // Start spawning the object with an initial delay of 0 seconds
        InvokeRepeating("Spawn", 0f, spawnInterval);
    }

    void Spawn()
    {
        //Locate center position
        Vector3 spawnPos = this.transform.position;
        spawnPos.y = -3.1f;
        // Set desired rotation with 90 degrees on each axis
        Quaternion rotation = Quaternion.Euler(0f, 90f, 0f);
        // Instantiate the prefab at the current game object's position and rotation
        Instantiate(prefabToSpawn, spawnPos, rotation);
    }
}
