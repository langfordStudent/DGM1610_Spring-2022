using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour
{
    public int numEwoks = 20;
    public int ducksInPond = 99;
    // Start is called before the first frame update
    void Start()
    {
        /*
        for(int i = 0; i <= numEwoks; i++)
        {
            Debug.Log("There are " + i + " Ewoks on a log!");
        }
        */

        while(ducksInPond > 0)
        {
            Debug.Log(ducksInPond);
            Debug.Log("All of the ducks have flown south for the winter, starting to feel lonely as you should!");
            ducksInPond--;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
