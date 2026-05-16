using UnityEngine;

public class MovingBackground : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] private float resetPosition = -10f; // Where it disappears at the bottom
    [SerializeField] private float startPosition = 10f;  // Where it teleports back to at the top

    void Update()
    {
        // Move the background down
        transform.Translate(Vector2.down * speed * Time.deltaTime);

        // If it goes past the reset point, teleport it back up
        if (transform.position.y <= resetPosition)
        {
            transform.position = new Vector2(transform.position.x, startPosition);
        }
    }
}

