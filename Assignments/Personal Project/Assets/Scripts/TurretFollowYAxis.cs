using UnityEngine;

public class TurretFollowYAxis : MonoBehaviour
{
    public float speed;
    public float stayOnYAxis;
    public float agroRange;
    private Transform player;
    private Vector3 goToTarget;
    public bool foundTarget;
    //private PatrolTurret patrol;
    //private ShootingTurret safetyOff;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        foundTarget = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, player.position) < agroRange)
        {
            goToTarget = new Vector3(player.position.x, stayOnYAxis, 0);
            transform.position = Vector3.MoveTowards(transform.position, goToTarget, speed * Time.deltaTime);
            //StopPatrol();
            //OpenFire();
        }
    }

    /*
    void StopPatrol()
    {
        foundTarget = true;
        if (foundTarget == true)
        {
            patrol.patrolOff = false;
        }
        else
        {
            patrol.patrolOff = true;
        }
    }
    */
    /*
    void OpenFire()
    {
        foundTarget = true;
        if (foundTarget == true)
        {
            safety.closedFire = false;
        }
    }
    */
}
