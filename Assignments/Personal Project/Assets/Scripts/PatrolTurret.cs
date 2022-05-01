using UnityEngine;

public class PatrolTurret : MonoBehaviour
{
    [Header("Patrol Attributes")]
    public float speed;
    private float waitTime;
    public float startWaitTime;
    public Transform waitPoint;
    public bool patrolOff;

    [Header("Patrol Bounds")]
    public float minX;
    public float maxX;
    public float patrolPlane;

    // Start is called before the first frame update
    void Start()
    {
        waitTime = startWaitTime;

        waitPoint.position = new Vector3(Random.Range(minX, maxX), patrolPlane, 0);

        patrolOff = false;
    }

    // Update is called once per frame
    void Update()
    {        
        if (patrolOff == false)
        {
            transform.position = Vector3.MoveTowards(transform.position, waitPoint.position, speed * Time.deltaTime);

            if (Vector3.Distance(transform.position, waitPoint.position) < 0.2f)
            {
                if (waitTime <= 0)
                {
                    waitPoint.position = new Vector3(Random.Range(minX, maxX), patrolPlane, 0);

                    waitTime = startWaitTime;
                }
                else
                {
                    waitTime -= Time.deltaTime;
                }
            }
        }            
    }
}