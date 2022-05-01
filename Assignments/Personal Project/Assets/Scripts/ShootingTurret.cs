using UnityEngine;

public class ShootingTurret : MonoBehaviour
{
    private Transform target;
    private float shotDelay;
    public float startDelay;
    public GameObject projectile;
    public Transform shootFromHere;
    private TurretFollowYAxis enemyScript;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        enemyScript = GameObject.FindGameObjectWithTag("Enemy").GetComponent<TurretFollowYAxis>();
        shotDelay = startDelay;
    }

    // Update is called once per frame
    void Update()
    {

        if (shotDelay <= 0 && Vector3.Distance(transform.position, target.position) < enemyScript.agroRange)
        {
            Instantiate(projectile, shootFromHere.position, Quaternion.identity);
            shotDelay = startDelay;
        }
        else
        {
            shotDelay -= Time.deltaTime;
        }
    }
}
