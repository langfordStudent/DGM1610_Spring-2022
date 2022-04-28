using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public int sceneToLoad;

    public void StartGame()
    {
        SceneManager.LoadScene(sceneToLoad); // Scene to Load
    }

    public void QuitGame()
    {
        Application.Quit(); // Quit Game
        Debug.Log("Quit Game, Bye Bye."); // Print to Console
    }
}
