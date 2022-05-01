using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed;
    private Transform player;
    private Vector3 target;
    private PlayerController playerController;
    public int damage = 1;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        target = new Vector3(player.position.x, player.position.y, 0);

        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
        if (transform.position.x == target.x && transform.position.y == target.y)
        {
            DestroyProjectile();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            DestroyProjectile();
            playerController.TakeDamage(damage);
        }
        else if (other.CompareTag("Platform"))
        {
            DestroyProjectile();
        }
    }
    void DestroyProjectile()
    {
        Destroy(gameObject);
    }
}
