using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    InputManager inputManager;
    Vector3 moveDirection;
    Transform CameraObject;
    Rigidbody playerRigidbody;
    public float movementSpeed = 8;
    public float rotationSpeed = 15f;


    private void Awake()
    {
        inputManager = GetComponent<InputManager>();
        playerRigidbody = GetComponent<Rigidbody>();
        CameraObject = Camera.main.transform;
    }
    private void HandleMovement()
    {

        moveDirection = CameraObject.forward * inputManager.verticalInput;
        moveDirection = moveDirection + CameraObject.right * inputManager.HorizontalInput;
        moveDirection.y = 0;
        moveDirection.Normalize();
        moveDirection = moveDirection * movementSpeed;

        Vector3 movementVelocity = moveDirection;
        playerRigidbody.linearVelocity = movementVelocity;
        

    
    }


}
