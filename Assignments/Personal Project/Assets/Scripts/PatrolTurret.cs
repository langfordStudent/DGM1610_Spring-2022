using UnityEngine;

public class PatrolTurret : MonoBehaviour
{
    [Header("Patrol Attributes")]
    public float speed;
    private float waitTime;
    public float startWaitTime;
    public Transform waitPoint;

    [Header("Patrol Bounds")]
    public float minX;
    public float maxX;
    public float patrolYAxisPlane;

    // Start is called before the first frame update
    void Start()
    {
        waitTime = startWaitTime;
        waitPoint.position = new Vector3(Random.Range(minX, maxX), patrolYAxisPlane, 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, waitPoint.position, speed * Time.deltaTime);

        if (Vector3.Distance(transform.position, waitPoint.position) < 0.2f)
        {
            if (waitTime <= 0)
            {
                waitPoint.position = new Vector3(Random.Range(minX, maxX), patrolYAxisPlane, 0);

                waitTime = startWaitTime;
            }
            else
            {
                waitTime -= Time.deltaTime;
            }
        }
    }
}