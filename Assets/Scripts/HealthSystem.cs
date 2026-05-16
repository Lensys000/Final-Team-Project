using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    [SerializeField] GameObject player;

    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip hurtSound;
    [SerializeField] AudioClip destroySound;

    public float health = 3.0f;

    public void DecreasePlayerHealth(float amount)
    {
        health -= amount;

        audioSource.PlayOneShot(hurtSound);

        if (health <= 0)
        {
            audioSource.PlayOneShot(destroySound);

            FindObjectOfType<RestartScript>().ShowRestartScreen();

            Destroy(player, 0.2f);
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