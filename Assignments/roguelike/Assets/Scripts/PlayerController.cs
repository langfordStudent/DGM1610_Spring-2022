using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Player Health")]
    public int curHP;
    public int maxHP;
    public HealthBar healthBar;

    [Header("Player Movement")]
    public float moveSpeed = 6f; //speed of player movement
    private Rigidbody2D rb; //store refecenced 2D rigidbody
    private Vector2 movement; // stores the players x,y position movements
    private Vector2 direction;

    [Header("Player Combat")]
    public int damage; //damage to be delt to enemy
    public float attackRange; // range of attack for player
    public float attackRate;
    public float lastAttackTime;
    public LayerMask enemyLayer;

    [Header("Inventory")]
    public int keys;
    public int coins;
    public int gems;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        curHP = maxHP;
        healthBar.SetHealth(maxHP);
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxis("Horizontal"); // input for left/right movement
        movement.y = Input.GetAxis("Vertical"); // input for up/down movement

        if (Input.GetKeyDown(KeyCode.X))
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

        UpdateDirection();
    }

    void UpdateDirection()
    {
        Vector2 vel = new Vector2(movement.x, movement.y);

        if (vel.magnitude != 0)
        {
            direction = vel;
        }

        rb.velocity = vel * moveSpeed;
    }

    void Attack()
    {
        lastAttackTime = Time.time;
        // Raycast using the enemyLayer

        RaycastHit2D hit = Physics2D.Raycast(transform.position, direction, attackRange, enemyLayer);

        if (hit.collider != null)
        {
            hit.collider.GetComponent<Enemy>()?.TakeDamage(damage);
        }
    }

    public void TakeDamage(int damage)
    {
        curHP -= damage;

        healthBar.SetHealth(curHP);

        if (curHP <= 0)
        {
            Die();
        }

    }

    void Die()
    {
        Debug.Log("YOU DIED! GIT GUD, SCRUB...");
    }
}
