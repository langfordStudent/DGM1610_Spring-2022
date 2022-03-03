using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 6f; //speed of player movement
    private Rigidbody2D rb; //store refecenced 2D rigidbody

    Vector2 movement; // stores the players x,y position movements
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxis("Horizontal"); // input for left/right movement
        movement.y = Input.GetAxis("Vertical"); // input for up/down movement
    }
    
    // set number of calls per frame
    void FixedUpdate()
    {
        // applies physics and move the character 
        rb.MovePosition(rb.position + movement * moveSpeed * Time.deltaTime);
    }
}
