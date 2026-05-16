using UnityEngine;

public class MeteorMovement : MonoBehaviour
{
    private float rotationSpeed = -75;
    [SerializeField]float meteorSpeed;
    public float destroyHeight = -15f;

    void Start()
    {
        meteorSpeed = Random.Range(1, 5);
    }
    void Update()
    {
        transform.Translate(Vector3.down * meteorSpeed * Time.deltaTime, Space.World);
        transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);

        if (transform.position.y < destroyHeight)
        {
            Destroy(gameObject);
        }
    }
}
