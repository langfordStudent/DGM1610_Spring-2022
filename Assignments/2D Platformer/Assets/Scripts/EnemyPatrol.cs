using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    public float speed;
    public float distance;
    private bool moveRight = true;
    public Transform groundCheck;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Enemy is moving to the right
        transform.Translate(Vector2.right * speed * Time.deltaTime);

        RaycastHit2D groundInfo = Physics2D.Raycast(groundCheck.position, Vector2.down, distance);

        if(groundInfo.collider == false)
        {
            if (moveRight == true)
            {
                // Flip enemy at an edge to move left
                transform.eulerAngles = new Vector3(0, -180, 0);
                moveRight = false;
            }
            else
            {
                // Flip enemy to move right
                transform.eulerAngles = new Vector3(0,0,0);
                moveRight = true;
            }
        }
    }
}
