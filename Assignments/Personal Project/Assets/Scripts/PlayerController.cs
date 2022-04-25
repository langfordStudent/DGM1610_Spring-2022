using UnityEngine;

public class PlayerController : MonoBehaviour
{

    [Header("PlayerAttributes")]
    public float speed;
    public float jumpHeight;
    private Rigidbody rb;
    private float moveVelocity;

    [Header("PlatformSpawner")]
    public GameObject platformHoriz;
    public GameObject platformVert;
    public int offsetPlatform;

    [Header("PlatformCheck")]
    public LayerMask platformLayerMask;
    public float maxDistance;
    public Transform platformCheck;


    //[Header("WallCheck")]
    //public LayerMask wallLayerMask;
    //public float distance;
    //public Transform wallCheckLeft;
    //public Transform wallCheckRight;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
    // Jump from the ground and from platforms with spacebar input
    // https://docs.unity3d.com/ScriptReference/Physics.Raycast.html
        if (Physics.Raycast(platformCheck.position, Vector3.down, out hit, maxDistance, platformLayerMask) && Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector3(rb.velocity.x, jumpHeight, 0);
        }

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

    private Vector3 PlayerPos()
    {
        return GameObject.FindGameObjectWithTag("Player").transform.position;
    }
}
