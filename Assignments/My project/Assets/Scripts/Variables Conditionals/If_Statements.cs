using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class If_Statements : MonoBehaviour
{
    // public string lightColor;
    public string weather;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        /*
        if(lightColor == "Red")
        {
            Debug.Log("The light is "+ lightColor +" STOP!!!!");
        }
        if (lightColor == "Yellow")
        {
            Debug.Log("The light is "+ lightColor +" be ready to STOP or hurry before it turns red!!!!");
        }
        if (lightColor == "Green")
        {
            Debug.Log("The light is "+ lightColor +" don't you dare stop!!!!)
        }
        */

       if(weather == "Rain" || weather =="Snow")
        {
            Debug.Log("The weather is bad, you should wear a coat!");
        }
       else if(weather == "Sunny" || weather == "Partly Cloudy")
        {
<<<<<<< HEAD
            Debug.Log("You do not need a coat, get a job!");
=======
            Debug.Log("You do not need a coat, get a job!")
>>>>>>> main
        }
    }

}
