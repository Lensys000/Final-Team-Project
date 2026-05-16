using UnityEngine;

public class Powerup2: MonoBehaviour
{
    public float moveSpeed = 4f;
    private float timeSinceSpawned = 0f;
    public float lifetime = 10f;


    void Update()
    {
        transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);

        timeSinceSpawned += Time.deltaTime;
        if (transform.position.y < -15 || timeSinceSpawned > lifetime)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
     
            other.transform.localScale = new Vector3(4.5f, 4.5f, 4f);

            Movement movement = other.GetComponent<Movement>();
            if (movement != null)
            {
                movement.moveSpeed -= 2;
                movement.moveSpeed = Mathf.Max(movement.moveSpeed, 7);
            }

            HealthSystem healthSystem = other.GetComponent<HealthSystem>();
            if (healthSystem != null)
            {
                healthSystem.AddHealth(2f);
            }

            Destroy(gameObject);
        }
    }
}