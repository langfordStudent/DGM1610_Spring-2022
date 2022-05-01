using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platforms : MonoBehaviour
{
    private float timeToDestroy = 1.75f;

    void Update()
    {
        timeToDestroy -= Time.deltaTime;
        
        if(timeToDestroy <= 0)
        {
            Destroy(gameObject);
        }
    }    
}
