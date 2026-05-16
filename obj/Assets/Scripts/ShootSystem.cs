using UnityEngine;
using UnityEngine.InputSystem;

public class ShootSystem : MonoBehaviour
{
    public Transform Shootingpoint;
    [SerializeField] GameObject bullet;
    [SerializeField] float shootDelay = 0.1f;

    private float timeSinceLastShot = 0;

    void Update()
    {
        timeSinceLastShot += Time.deltaTime;

        if (Keyboard.current.spaceKey.isPressed && timeSinceLastShot >= shootDelay)
        {
            Instantiate(bullet, Shootingpoint.position, transform.rotation);
            timeSinceLastShot = 0;
        }
    }
}