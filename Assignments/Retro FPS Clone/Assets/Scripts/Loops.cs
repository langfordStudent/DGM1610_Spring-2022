using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour
{
    public int numEwoks = 20;
    public int ducksInPond = 99;
    public int problems = 0;
    public int bottles = 99;
    public int count = 0;
    public int max = 10000;
    public int min = 0;
    // Start is called before the first frame update
    void Start()
    {        
        for(int i = 0; i <= numEwoks; i++)
        {
            Debug.Log("There are " + i + " Ewoks on a log!");
        }
                
        for(int i = 99; i > 0; i--)
        {
            Debug.Log(i + " bottles of beer on the wall. " + i + " bottles of beer. Take one down, pass it around, " + (i - 1) + " bottles of beer on the wall.");
            if(i == 1)
            {
                Debug.Log(i + " bottle of beer on the wall. " + i + " bottle of beer. Take it down, pass it around, " + (i - 1) + " bottles of beer on the wall.");
                break;
            }
        }

        while(bottles > 0)
        {
            Debug.Log(bottles + " bottles of beer on the wall. " + bottles + " bottles of beer. Take one down, pass it around, " + (bottles - 1) + " bottles of beer on the wall.");
            if(bottles == 1)
            {
                Debug.Log(bottles + " bottle of beer on the wall. " + bottles + " bottle of beer. Take it down, pass it around, " + (bottles - 1) + " bottles of beer on the wall.");
                break;
            }
            else
            {
                bottles--;
            }
            
        }

        while(ducksInPond > 0)
        {
            Debug.Log(ducksInPond);
            Debug.Log("All of the ducks have flown south for the winter, starting to feel lonely as you should!");
            ducksInPond--;
        }

        for(int i = 0; i <= 99; i++)
        {
            Debug.Log("I got " + i + " problems but a b**** ain't one");
        }
        
        while(problems < 100)
        {
            Debug.Log("I got " + problems + " problems but a b**** ain't one");
            ++problems;
        }
        
        for(int i = 0; i <= 100; i++)
        {
            Debug.Log(i);
            if(i == 100)
            {
                Debug.Log("real quick.")
            }
        }

        while(count < 101)
        {
            Debug.Log(count);
            if(count == 100)
            {
                Debug.Log("real quick.");
                break;
            }
            else
            {
                count++;
            }
        }

        for(int i = min; i<= max; i++)
        {
            min++;
            if (min == max)
            {
                Debug.Log("I am a computer, I have counted to " + max + ". Too easy.");
            }
        }

        while(min < max + 1)
        {
            min++;
            if(min == max)
            {
                Debug.Log("I am a computer, I have counted to " + max + ". Too easy.");
            }
        }
    }       
}
