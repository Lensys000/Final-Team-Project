using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RestartScript : MonoBehaviour
{
    [SerializeField] Button restartButton;

    void Start()
    {
        restartButton.gameObject.SetActive(false);
    }

    public void ShowRestartScreen()
    {
        restartButton.gameObject.SetActive(true);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }
}