using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Jump : MonoBehaviour
{
    //private MovementT movementscript;
    private Vector3 velocity;

    private CharacterController characterController;

    private bool jumpPressed = false;
    private bool canJump = false;
    [SerializeField] private float fallingSpeed;
    [SerializeField] private float jumpForce;
    [SerializeField] private float maxForce;
    [SerializeField] private float buttonTime = 0.3f;

    public float fallingspeed
    {
        get { return fallingSpeed; }
        set { fallingSpeed = value; }
    }
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }
    void Update()
    {
        if (jumpPressed && velocity.y < maxForce && canJump) {
            velocity.y += jumpForce * Time.deltaTime;                 
        }
        
        characterController.Move(velocity);

        if (velocity.y > Physics.gravity.y && !characterController.isGrounded) { 
            velocity.y -= fallingSpeed * Time.deltaTime;
        }
        if (characterController.isGrounded) {
            velocity.y = 0f;
            canJump = true;
        }
    }
    public void JumpInput(InputAction.CallbackContext ctx)
    {
        if(ctx.action.phase == InputActionPhase.Started)
        {
            jumpPressed = true;
            velocity.y = 0f;
            StartCoroutine(JumpTimeUp());
        }
        if (ctx.action.phase == InputActionPhase.Canceled) {
            jumpPressed = false;
        }
    }
    IEnumerator JumpTimeUp() { 
        yield return new WaitForSeconds(buttonTime);
        jumpPressed = false;
        canJump = false;
    }
}
