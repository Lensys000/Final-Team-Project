using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Handles the core main menu interactions for the 2D game project.
/// </summary>
public class MainMenu : MonoBehaviour
{
    [Header("Scene Routing Configuration")]
    [Tooltip("The exact name of the 2D gameplay scene to load.")]
    [SerializeField] private string targetSceneName = "GameScene";

    /// <summary>
    /// Transition the application from the main menu to the active gameplay scene.
    /// </summary>
    public void StartGame()
    {
        // Fail-safe validation to prevent a runtime crash if the inspector field is null
        if (string.IsNullOrWhiteSpace(targetSceneName))
        {
            Debug.LogError("[MainMenu System Error]: Target scene name string is null or empty. Please assign a valid scene name in the Unity Inspector.");
            return;
        }

        // Execute the scene transition
        SceneManager.LoadScene(targetSceneName);
    }
}