using UnityEngine;

public class PunjiPit : MonoBehaviour
{
    private PlayerController player;
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
    }
    void OnTriggerEnter(Collider collider)
    {
        
        if (collider.CompareTag("Player"))
        {
            player.DeathToPlayer();
        }
    }
}