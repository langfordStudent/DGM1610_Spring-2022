using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    private Vector3 offset = new Vector3(-2.75f, 2.5f, -10.5f);

    // Update is called once per frame
    void Update()
    {
        if (player == null)
        {
            enabled = false;
        }
        else
        {
            transform.position = player.transform.position + offset;
        }
    }
}
