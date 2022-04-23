using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Time.smoothDeltaTime);
    }
}
/*
 public GameObject[] objectPrefabs;
private float spawnDelay = 2;
private float spawnInterval = 1.5f;

private PlayerControllerX playerControllerScript;

// Start is called before the first frame update
void Start()
{
    InvokeRepeating("SpawnObjects", spawnDelay, spawnInterval);
    playerControllerScript = GameObject.Find("Player").GetComponent<PlayerControllerX>();
}

// Spawn obstacles
void SpawnObjects ()
{
    // Set random spawn location and random object index
    Vector3 spawnLocation = new Vector3(30, Random.Range(5, 15), 0);
    int index = Random.Range(0, objectPrefabs.Length);

    // If game is still active, spawn new object
    if (!playerControllerScript.gameOver)
    {
        Instantiate(objectPrefabs[index], spawnLocation, objectPrefabs[index].transform.rotation);
    }

}
*/