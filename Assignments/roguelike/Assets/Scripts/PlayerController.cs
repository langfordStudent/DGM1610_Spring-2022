using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header ("Player Health")]
    
    public int curHP;
    public int maxHP;

    [Header("Player Movement")]

    public float moveSpeed = 6f; //speed of player movement
    private Rigidbody2D rb; //store refecenced 2D rigidbody

    private Vector2 movement; // stores the players x,y position movements

    private Vector2 direction;

    [Header("Player Combat")]
    
    public float attackRange;

    public float attackRate;

    public float lastAttackTime;

    public int damage;

    public LayerMask enemyLayer;


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
        
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if (Time.time - lastAttackTime >= attackRate)
                Attack();
        }
    }
    
    // set number of calls per frame
    void FixedUpdate()
    {
        // applies physics and move the character 
        rb.MovePosition(rb.position + movement * moveSpeed * Time.deltaTime);
    }

    //void UpdateDirection()
    //{
        //Vector2 vel = Vector2(movement.x,movement.y);
        //if (vel.magnitude != 0)
        //{
            //rb.velocity = vel;
        //}

        //rb.velocity = vel * moveSpeed;
    //}

    void Attack()
    {
        lastAttackTime = Time.time;
        // Raycast using the enemyLayer

        RaycastHit2D hit = Physics2D.Raycast(transform.position, direction, attackRange, enemyLayer);

        if(hit.collider != null)
        {
            hit.collider.GetComponent<Enemy>()?.TakeDamage(damage);
        }
    }

    public void TakeDamage(int damage)
    {
        curHP -= damage;

        if (curHP <= 0)
        {
            Die();
        }

    }

    void Die()
    {
        Debug.Log("YOU DIED");
    }
}
