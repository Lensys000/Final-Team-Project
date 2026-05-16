using UnityEngine;

public class EnemyShip1 : MonoBehaviour
{
    public float moveSpeed = 5f;

    public float waveSpeed = 3f;
    public float waveAmount = 2f;

    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        // Move ship down
        transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);

        // side to side movement
        float xMovement = Mathf.Sin(Time.time * waveSpeed) * waveAmount;

        transform.position = new Vector3(
            startPosition.x + xMovement,
            transform.position.y,
            transform.position.z
        );

        // Destroy if off screen
        if (transform.position.y < -15)
        {
            Destroy(gameObject);
        }
    }
}