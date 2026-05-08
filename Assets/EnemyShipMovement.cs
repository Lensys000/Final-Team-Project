using UnityEngine;

public class EnemyShip1 : MonoBehaviour
{
    int SpeedDown = 6;
    int SpeedLeftR = 8;
    private float timer = 0;
    void Update()
    {
        timer += Time.deltaTime;

        transform.Translate(Vector3.down * SpeedDown * Time.deltaTime);

    }
}
