using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleCalc : MonoBehaviour
{

    // Access Modifier DataType Name;
    public int numberA = 10;
    public int numberB = 33;
    public int numberC = 7;
    public float numberD = 33.0f;
    public float numberE = 7.0f;
    // Start is called before the first frame update
    void Start()
    {
        Add();
        Subtract();
        Mult();
        Div();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Add()
    {
        int total;
        total = numberA + numberB;
        Debug.Log(numberA +" + "+ numberB +" = "+ total);
    }
    void Subtract()
    {
        int total;
        total = numberB - numberC;
        Debug.Log(numberB +" - "+ numberC +" = "+ total);
    }
    void Mult()
    {
        int total;
        total = numberB * numberB;
        Debug.Log(numberB +" x "+ numberB +" = "+ total);
    }
    void Div()
    {
        int total;
        int rem;
        float tot;
        total = numberB / numberC;
        tot = numberD / numberE;
        rem = numberB % numberC;
        Debug.Log(numberB +" / "+ numberC +" = "+ total);
        Debug.Log("Remainder = "+ rem);
        Debug.Log(numberD +" / "+ numberE +" = "+ tot);
    }
}

