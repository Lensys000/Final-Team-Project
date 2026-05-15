using UnityEngine;
using UnityEngine.SceneManagement; // Essential for loading scenes

public class MainMenu : MonoBehaviour
{
    // This function must be public so your UI button can see it
    public void StartGame()
    {
        // Double-check that this matches your actual 2D level name exactly
        SceneManager.LoadScene("GameScene");
    }
}

