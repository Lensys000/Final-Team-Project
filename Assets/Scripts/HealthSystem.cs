using UnityEngine;
public class HealthSystem : MonoBehaviour
{
    [SerializeField] GameObject player;
    public float health = 3.0f;

    public void DecreasePlayerHealth(float amount)
    {
        health -= amount;
        if (health <= 0)
        {
            FindObjectOfType<RestartScript>().ShowRestartScreen();
            Destroy(player);
        }
    }

    public void AddHealth(float amount)
    {
        health += amount;
        health = Mathf.Min(health, 6f);
    }

    public float Health
    {
        get { return health; }
        private set { health = value; }
    }
}