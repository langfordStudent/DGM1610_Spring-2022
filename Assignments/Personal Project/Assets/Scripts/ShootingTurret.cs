using UnityEngine;

public class ShootingTurret : MonoBehaviour
{
    private Transform target;
    private float shotDelay;
    public float startDelay;
    public GameObject projectile;
    public Transform shootFromHere;
    //public bool closedFire;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        shotDelay = startDelay;
        //closedFire = true;
    }

    // Update is called once per frame
    void Update()
    {
        //if (closedFire == false)
        //{
        if (shotDelay <= 0)
        {
            Instantiate(projectile, shootFromHere.position, Quaternion.identity);
            shotDelay = startDelay;
        }
        else
        {
            shotDelay -= Time.deltaTime;
        }
        //}
    }
}
