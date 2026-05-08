using UnityEngine;

public class MeteorMovement : MonoBehaviour
{
    private float rotationSpeed = -75;
    float meteorSpeed;
    void Start()
    {
        meteorSpeed = Random.Range(5, 15);
    }
    void Update()
    {
        transform.Translate(Vector3.down * meteorSpeed * Time.deltaTime, Space.World);
        transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
    }
}
