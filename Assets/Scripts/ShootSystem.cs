using UnityEngine;
using UnityEngine.InputSystem;

public class ShootSystem : MonoBehaviour
{
    public Transform Shootingpoint;

    [SerializeField] GameObject bullet;
    [SerializeField] float shootDelay = 0.1f;

    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip shootSound;

    private float timeSinceLastShot = 0;

    void Update()
    {
        timeSinceLastShot += Time.deltaTime;

        if (Keyboard.current.spaceKey.isPressed && timeSinceLastShot >= shootDelay)
        {
            Instantiate(bullet, Shootingpoint.position, transform.rotation);

            audioSource.PlayOneShot(shootSound);

            timeSinceLastShot = 0;
        }
    }
}