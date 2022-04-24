using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [Header("PlayerAttributes")]
    public float speed;
    public float jumpHeight;
    private Rigidbody rb;
    private float moveVelocity;

    [Header("GroundCheck")]
    private bool isGrounded;
    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask assignGround;

    [Header("Platform Spawner")]
    public int platformLimit;
    public GameObject platformHoriz;
    public GameObject platformVert;
    public int offsetPlatform;


    //[Header("WallCheck")]
    //private bool isHuggingWall;
    //public Transform wallCheck;
    //public LayerMask assignWall;
    //public float wallCheckRadius;

    // Start is called before the first frame update
    void Start()
    {
        isGrounded = true;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // NEED TO FIX GROUND CHECK FOR 3D ENVIRONMENT!!!
        //isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, assignGround);

        // Non-Stick Player
        moveVelocity = 0f;

        // Input to move right
        if (Input.GetKey(KeyCode.D))
        {
            moveVelocity = speed;
        }

        // Input to move left
        if (Input.GetKey(KeyCode.A))
        {
            moveVelocity = -speed;
        }

        rb.velocity = new Vector3(moveVelocity, rb.velocity.y, 0);

        // Jump from the ground and from platforms
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.velocity = new Vector3(rb.velocity.x, jumpHeight, 0);
        }

        // Retrieve current player position
        Vector3 player = GameObject.FindGameObjectWithTag("Player").transform.position;

        // Spawn horizontal platform above the player
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Vector3 spawnPos = new Vector3(player.x, player.y + offsetPlatform, 0);
            Instantiate(platformHoriz, spawnPos, Quaternion.identity);
        }

        // Spawn horizontal platform below the player
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Vector3 spawnPos = new Vector3(player.x, player.y - offsetPlatform, 0);
            Instantiate(platformHoriz, spawnPos, Quaternion.identity);
        }

        // Spawn vertical platform left of the player
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Vector3 spawnPos = new Vector3(player.x - offsetPlatform, player.y, 0);
            Instantiate(platformVert, spawnPos, Quaternion.identity);
        }

        // Spawn vertical platform right of the player
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Vector3 spawnPos = new Vector3(player.x + offsetPlatform, player.y, 0);
            Instantiate(platformVert, spawnPos, Quaternion.identity);
        }
    }
}
