using UnityEngine;

public class EnemyShip2 : MonoBehaviour
{
    public float moveSpeed = 6f;

    private Transform player;

    void Start()
    {
        GameObject playerObject = GameObject.FindGameObjectWithTag("Player");

        if (playerObject != null)
        {
            player = playerObject.transform;
        }
    }

    void Update()
    {
        if (player != null)
        {
            // move towards player
            transform.position = Vector3.MoveTowards(
                transform.position,
                player.position,
                moveSpeed * Time.deltaTime
            );
        }

        // destroys ship if off screen
        if (transform.position.y < -20)
        {
            Destroy(gameObject);
        }
    }
}