using UnityEngine;

public class InputManager : MonoBehaviour
{
    //miPrimerSCRIPT :3
    PlayerControls playerControls;
    public Vector2 movementInput;

    public float verticalInput;
    public float HorizontalInput;

    private void OnEnable()
    {
        if (playerControls == null)
        {
            playerControls = new PlayerControls();
            playerControls.Playermovement.HorizontalMovement.performed += i => movementInput = i.ReadValue<Vector2>();


        }
        playerControls.Enable();
    }

    void OnDisable()
    {
        playerControls.Disable();
    }

    private void HandleMovementInput()
    {
        verticalInput = movementInput.y;
        HorizontalInput = movementInput.x;

    }
    private void HandleAllInputs()


    {
        HandleAllInputs();
    //JumpingInput();
        //Any Other fuction we Need!

    }
}
