using UnityEngine;
using UnityEngine.SceneManagement;
public class EndpointGameComplete : MonoBehaviour
{
    void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("Player"))
        {
            Application.Quit();
        }
    }
}