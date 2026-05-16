using TMPro;
using UnityEngine;

public class ScoreUi : MonoBehaviour
{
    public static ScoreUi instance;
    [SerializeField] TextMeshProUGUI scoreText;
    int score = 0;

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        UpdateScoreText();
    }

    public void AddScore(int amount)
    {
        score += amount;
        UpdateScoreText();
    }

    void UpdateScoreText()
    {
        scoreText.text = "Score: " + score;
    }
}