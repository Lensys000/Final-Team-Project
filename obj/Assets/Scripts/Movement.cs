using UnityEngine;

public class playerMovement : MonoBehaviour
{
        private int moveSpeed = 9;
    void Update()
        {
            float horizontalInput = Input.GetAxis("Horizontal");
            float verticalInput = Input.GetAxis("Vertical");

            transform.Translate(Vector3.right * horizontalInput * moveSpeed * Time.deltaTime);
            transform.Translate(Vector3.up * verticalInput * moveSpeed * Time.deltaTime);
        }


}