using UnityEngine;

public class enemyCollision : MonoBehaviour
{ 
    private void OnCollisionEnter2D(Collision2D collision)
    {
        collision.gameObject.GetComponent<HealthSystem>().DecreasePlayerHealth(1);
    }
}
