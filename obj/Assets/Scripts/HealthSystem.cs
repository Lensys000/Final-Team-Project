using UnityEngine;
public class HealthSystem : MonoBehaviour
{
    [SerializeField] GameObject player;
    float health = 3;

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
    }

    public float Health
    {
        get { return health; }
        private set { health = value; }
    }
}