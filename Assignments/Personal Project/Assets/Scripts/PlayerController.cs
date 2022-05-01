using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    [Header("Player Health")]
    public int curHP;
    public int maxHP = 3;
    public HealthBar healthBar;

    [Header("Player Attributes")]
    public float speed;
    public float jumpHeight;
    private Rigidbody rb;
    private float moveVelocity;
    public float deathWait = 1.5f;

    [Header("Platform Spawner")]
    public GameObject platformHoriz;
    public GameObject platformVert;
    public int offsetPlatform;

    [Header("Platform & Wall Check")]
    public LayerMask platformLayerMask;
    public LayerMask wallLayerMask;
    public float maxDistance;
    public Transform platformCheckAbove;
    public Transform wallCheckLeft;
    public Transform wallCheckRight;
    public Transform platformCheckBelow;
    public bool isGrounded;
    public bool isHuggingWallRight;
    public bool isHuggingWallLeft;
    public bool isAbove;

    [Header("Scenes to Load After Death")]
    private int sceneToLoad = 0;

    [Header("Audio")]
    public AudioClip marker;
    private AudioSource source;
    public float loudness;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        isGrounded = true;
        curHP = maxHP;
        healthBar.SetHealth(maxHP);

        source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        // Check to see if the player is grounded
        if (Physics.Raycast(platformCheckBelow.position, Vector3.down, maxDistance, platformLayerMask))
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

        //Check to see if the player is hitting the platform above
        if (Physics.Raycast(platformCheckAbove.position, Vector3.up, maxDistance, platformLayerMask))
        {
            isAbove = true;
        }
        else
        {
            isAbove = false;
        }

        // Non-Stick Player
        moveVelocity = 0f;

        //Jump
        if (isGrounded == true && Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector3(rb.velocity.x, jumpHeight, 0);
            source.PlayOneShot(marker, loudness);
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
        if (Input.GetKeyDown(KeyCode.UpArrow) && isAbove == false)
        {
            Vector3 spawnPos = new Vector3(transform.position.x, transform.position.y + offsetPlatform, 0);
            Instantiate(platformHoriz, spawnPos, Quaternion.identity);
        }

        // Spawn horizontal platform below the player
        if (Input.GetKeyDown(KeyCode.DownArrow) && isGrounded == false)
        {
            Vector3 spawnPos = new Vector3(transform.position.x, transform.position.y - offsetPlatform, 0);
            Instantiate(platformHoriz, spawnPos, Quaternion.identity);
        }

        // Spawn vertical platform left of the player
        if (Input.GetKeyDown(KeyCode.LeftArrow) && isHuggingWallLeft == false)
        {
            Vector3 spawnPos = new Vector3(transform.position.x - offsetPlatform, transform.position.y, 0);
            Instantiate(platformVert, spawnPos, Quaternion.identity);
        }

        // Spawn vertical platform right of the player
        if (Input.GetKeyDown(KeyCode.RightArrow) && isHuggingWallRight == false)
        {
            Vector3 spawnPos = new Vector3(transform.position.x + offsetPlatform, transform.position.y, 0);
            Instantiate(platformVert, spawnPos, Quaternion.identity);
        }
    }

    public void TakeDamage(int damage)
    {
        curHP -= damage;

        healthBar.SetHealth(curHP);

        if (curHP <= 0)
        {
            DeathToPlayer();
        }
    }

    public void DeathToPlayer()
    {
        curHP = 0;
        Destroy(gameObject);
        deathWait -= Time.deltaTime;
        RestartToBegining();
    }

    public void RestartToBegining()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}