using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour
{
    private string[] friendNames = { "kayson", "andrew", "ben", "maria", "jackson", "marsha" };
    private int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
    private string[] songs = { "dont go breaking my heart", "the great gig in the sky", "hey jude", "love potion #9" };
    private float[] halfs = { 0.5f, 1.5f, 2.5f, 3.5f, 4.5f, 5.5f, 6.5f, 7.5f, 8.5f, 9.5f };
    private string[] foods = { "tacos", "pizza", "lollipops", "cupcakes", "glass" };
    private string[] objects = { "pencil", "lego", "shelf", "people named bob", "game paddle", "blanket" };
    private string[] hats = { "top hat", "ball cap", "dew rag", "a bad wig", "cowboy hat" };
    private string[] soft = { "pillow", "wife", "wife hair", "wife voice", "wife heart", "dog" };
    private string[] hard = { "pistol whip", "books", "death", "big boy drinks", "dwayne johnson" };
    private string[] funny = { "Will Forte", "children of divorce", "people falling", "avoidable incidents among small children", "derpy cats" };


    // Start is called before the first frame update
    void Start()
{
    foreach(int numbers in numbers)
    {
    print(numbers);
    }
}

    // Update is called once per frame
    void Update()
    {
        
    }
}
