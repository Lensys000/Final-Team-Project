using UnityEngine;
public class CompanionPowerUp : MonoBehaviour
{
    [SerializeField] GameObject playerPrefab;
    [SerializeField] float companionOffsetX = 1f;

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

                var movement = companion.GetComponent<playerMovement>();
                if (movement != null)
                    movement.enabled = false;
            }

            Destroy(gameObject);
        }
    }
}