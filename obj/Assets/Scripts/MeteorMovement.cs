using UnityEngine;

public class MeteorMovement : MonoBehaviour
{
    private float rotationSpeed = -75;
    [SerializeField]float meteorSpeed;
    void Start()
    {
        meteorSpeed = Random.Range(1, 4);
    }
    void Update()
    {
        transform.Translate(Vector3.down * meteorSpeed * Time.deltaTime, Space.World);
        transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
    }
}
