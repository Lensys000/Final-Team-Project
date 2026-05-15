using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float speed = 5.0f;
    private Rigidbody2D rb;
    void Update()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.linearVelocity = transform.up * speed;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        EnemyHealth enemy = other.GetComponent<EnemyHealth>();
        if (enemy != null)
        {
            enemy.DecreaseEnemyHealth(1f);
            Destroy(gameObject);
        }
    }
}