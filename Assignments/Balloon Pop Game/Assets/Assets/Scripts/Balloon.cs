using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour
{
    public int scoreToGive = 100; // base score for popping a balloon

    public int clickToPop = 3; // number of click for the balloon to pop

    public float scaleToIncrease = 0.10f; //Scale increase each time the ballon is clicked

    public ScoreManager scoreManager; // A variable to reference the ScoreManager

    // Start is called before the first frame update
    void Start()
    {
        //reference the ScoreManager component
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();        
    }

    // Update is called once per frame
    void Update()
    {
        //reduce clicks by 1
        clickToPop -= 1;
        //increase
        transform.localScale += Vector3.one * scaleToIncrease;
        if(clickToPop == 0)
        {
            scoreManager.IncreaseScoreText(scoreToGive);
            Destroy(gameObject);
        }        
    }
}
