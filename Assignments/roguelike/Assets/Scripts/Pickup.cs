using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public enum PickupType {Key, Coin, Gem};
    public PickupType currentPickup;
    public int pickupAmount;
    private PlayerController playerController;
    // Start is called before the first frame update
    void Start()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if(currentPickup == PickupType.Key)
            {
                playerController.keys = pickupAmount;
                Debug.Log("You picked up the golden key!");
            }
            else if(currentPickup == PickupType.Coin)
            {
                playerController.coins = pickupAmount;
                Debug.Log("You have picked up" + pickupAmount + " Coins");
            }
            else if (currentPickup == PickupType.Gem)
            {
                playerController.gems = pickupAmount;
                Debug.Log("You have picked up" + pickupAmount + " Gem");
            }
            Destroy(gameObject);
        }
    }        
}
