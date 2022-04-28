using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [Header("PlayerAttributes")]
    public float speed;
    public float jumpHeight;
    public float wallJumpHeight;
    private Rigidbody rb;
    private float moveVelocity;
    private bool frozenControls;

    [Header("PlatformSpawner")]
    public GameObject platformHoriz;
    public GameObject platformVert;
    public int offsetPlatform;

    [Header("PlatformAndWallCheck")]
    public LayerMask platformLayerMask;
    public LayerMask wallLayerMask;
    public float maxDistance;
    public Transform platformCheck;
    public Transform wallCheckLeft;
    public Transform wallCheckRight;
    private bool isGrounded;
    private bool isHuggingWallRight;
    private bool isHuggingWallLeft;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        frozenControls = false;
        isGrounded = true;
    }

    // Update is called once per frame
    void Update()
    {
        // Check to see if the player is grounded
        if (Physics.Raycast(platformCheck.position, Vector3.down, maxDistance, platformLayerMask))
        {
            isGrounded = true;
        }
        else
        {
            isGrounded = false;
        }

        //Check to see if the player is hugging the wall to the left
        if (Physics.Raycast(wallCheckLeft.position, Vector3.left, maxDistance, wallLayerMask))
        {
            isHuggingWallLeft = true;
        }
        else
        {
            isHuggingWallLeft = false;
        }

        //Check to see if the player is hugging the wall to the right
        if (Physics.Raycast(wallCheckRight.position, Vector3.right, maxDistance, wallLayerMask))
        {
            isHuggingWallRight = true;
        }
        else
        {
            isHuggingWallRight = false;
        }

        // Non-Stick Player
        moveVelocity = 0f;

        if (!frozenControls)
        {
            if (Physics.Raycast(platformCheck.position, Vector3.down, maxDistance, platformLayerMask) && Input.GetKeyDown(KeyCode.Space))
            {
                rb.velocity = new Vector3(rb.velocity.x, jumpHeight, 0);
            }

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

            // Spawn horizontal platform above the player
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                Vector3 spawnPos = new Vector3(PlayerPos().x, PlayerPos().y + offsetPlatform, 0);
                Instantiate(platformHoriz, spawnPos, Quaternion.identity);
            }

            // Spawn horizontal platform below the player
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                Vector3 spawnPos = new Vector3(PlayerPos().x, PlayerPos().y - offsetPlatform, 0);
                Instantiate(platformHoriz, spawnPos, Quaternion.identity);
            }

            // Spawn vertical platform left of the player
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                Vector3 spawnPos = new Vector3(PlayerPos().x - offsetPlatform, PlayerPos().y, 0);
                Instantiate(platformVert, spawnPos, Quaternion.identity);
            }

            // Spawn vertical platform right of the player
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                Vector3 spawnPos = new Vector3(PlayerPos().x + offsetPlatform, PlayerPos().y, 0);
                Instantiate(platformVert, spawnPos, Quaternion.identity);
            }
        }
        //else if ()
        //{

        //}
    }

    // Function to find the current position of the player 
    public Vector3 PlayerPos()
    {
        return GameObject.FindGameObjectWithTag("Player").transform.position;
    }
}
