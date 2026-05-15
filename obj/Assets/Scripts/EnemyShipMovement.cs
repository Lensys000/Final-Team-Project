using UnityEngine;

public class EnemyShip1 : MonoBehaviour
{
   [SerializeField] float SpeedDown = .1f;
    private float timer = 0;
    void Update()
    {
        timer += Time.deltaTime;

        transform.Translate(Vector3.down * SpeedDown * Time.deltaTime);

    }
}
