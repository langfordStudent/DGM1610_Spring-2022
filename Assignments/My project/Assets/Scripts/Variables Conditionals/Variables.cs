using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{
    public int money; //whole number values 2, 14, 5, -21 etc...
    
    public float change = 0.75f; // floating point number or decimal 3.15, 105.36 1.23 etc...
    
    public bool isDay = true; //Boolenas are ture or false

    public string loginName = "Bob42069"; //string are alpha numeric text contained in quations ""

    float waterBottle = 0.35f;

    // Start is called before the first frame update
    void Start()
    {
        money = 100;
        Debug.Log("Money in account = $" + money);
        waterBottle = 1.00f;
    }

    // Update is called once per frame
    void Update()
    {
      
    }
}
