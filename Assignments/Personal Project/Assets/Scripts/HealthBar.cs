using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    private PlayerController player;
    public Slider slider;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
    }
    public void SetMaxHealth(int health)
    {
        slider.maxValue = player.maxHP;
        slider.value = health;
    }

    public void SetHealth(int health)
    {
        slider.value = health;
    }
}
