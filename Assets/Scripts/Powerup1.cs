using UnityEngine;
public class CompanionPowerUp : MonoBehaviour
{
    [SerializeField] GameObject playerPrefab;
    [SerializeField] float companionOffsetX = 1f;
    public float moveSpeed = 4f;
    public float lifetime = 10f;
    private float timeSinceSpawned = 0f;

    private void Update()
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
            HealthSystem healthSystem = other.GetComponent<HealthSystem>();
            if (healthSystem != null)
                healthSystem.AddHealth(1);

            if (other.transform.Find("Ship2") == null)
            {
                GameObject companion = Instantiate(playerPrefab,
                    Vector3.zero,
                    other.transform.rotation);

                companion.name = "Ship2";
                companion.transform.SetParent(other.transform);
                companion.transform.localPosition = new Vector3(companionOffsetX, 0, 0);

                var movement = companion.GetComponent<Movement>();
                if (movement != null)
                    movement.enabled = false;
            }

            Destroy(gameObject);
        }
    }
}