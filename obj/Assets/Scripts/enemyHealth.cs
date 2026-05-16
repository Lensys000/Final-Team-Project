using UnityEngine;
using UnityEngine.SceneManagement;
public class EnemyHealth : MonoBehaviour
{
    public float health = 1f;

    public void DecreaseEnemyHealth(float amount)
    {
        health -= amount;
        if (health <= 0)
        {
            ScoreUi.instance.AddScore(10);
            Destroy(gameObject);
        }
    }

    public float Health
    {
        get { return health; }
        private set { health = value; }
    }
}