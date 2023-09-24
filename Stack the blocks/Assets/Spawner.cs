using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject plankPrefab; // Assign your plank prefab in the Unity Inspector
    public float spawnDelay = 1.0f; // Set your desired delay between spawns

    // Start is called before the first frame update
    void Start()
    {
        // Call the Begin method to start spawning
        //Begin();
    }

    // Update is called once per frame
    void Update()
    {
        // You can add conditions here to trigger spawning if needed
        // For example, spawn planks in response to user input
        if (Input.GetMouseButtonDown(0))
        {
            Begin();
        }
    }

    // Coroutine for spawning planks
    IEnumerator waiter()
    {
        // Wait for the specified delay
        yield return new WaitForSeconds(spawnDelay);

        // Create a new plank at the spawner's position with appropriate Y-coordinate
        Vector3 spawnPosition = transform.position;
        float newY = 2.51f; // Adjust the Y-coordinate as needed
        spawnPosition.y = newY;
        
        // Create the plank and set gravity scale
        GameObject newPlank = Instantiate(plankPrefab, spawnPosition, Quaternion.identity);
        Rigidbody2D plankRigidbody = newPlank.GetComponent<Rigidbody2D>();
        plankRigidbody.gravityScale = 0;
    }

    // Method to start the spawning coroutine
    void Begin()
    {
        StartCoroutine(waiter());
    }
}
