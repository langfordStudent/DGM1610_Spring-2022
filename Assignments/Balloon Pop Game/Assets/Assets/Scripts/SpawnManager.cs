using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] balloonPrefabs;
    public float startDelay = 0.5f;
    public float spawnInterval = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomBalloon", startDelay, spawnInterval);   
    }

    // Update is called once per frame
    void SpawnRandomBalloon()
    {
        // get a random postion on the x-axis
        Vector3 spawnPos = new Vector3(Random.Range(-5,5),10,0);
        // pick a random balloon from the ballooon array 
        int balloonIndex = Random.Range(0,balloonPrefabs.Length);
        // Spawn random balloon at spawn positions
        Instantiate(balloonPrefabs[balloonIndex], spawnPos, balloonPrefabs[balloonIndex].transform.rotation);
    }
}
