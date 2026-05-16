using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float destroyHeight = 15f;
    public float speed = 5.0f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        rb.linearVelocity = transform.up * speed;

        if (transform.position.y > destroyHeight)
        {
            Destroy(gameObject);
        }
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