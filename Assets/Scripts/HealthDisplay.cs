using UnityEngine;
using TMPro;
public class HealthDisplay : MonoBehaviour
{
    [SerializeField] TMP_Text healthText;
    [SerializeField] HealthSystem playerHealth;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        healthText.text = "Health: " + playerHealth.Health;
    }
}
