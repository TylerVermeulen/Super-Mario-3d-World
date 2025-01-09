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
   
    /*
    public MovementT Movementscript
    {
        set {  movementscript = value; }
    }
    */
    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
       // movementscript = this.GetComponent<MovementT>();
        
    }

    // Update is called once per frame
    void Update()
    {/*
        if(movementscript.Vwely > Physics.gravity.y)
        {
            vel.y -= fallingSpeed;
        }*/
        //Debug.Log(jumpPressed);
        
       
        if (jumpPressed && velocity.y < maxForce && canJump) {
            //velocity.y = 0f;
            Debug.Log("vel"+velocity);
            velocity.y += jumpForce * Time.deltaTime;                 
        }
        
        characterController.Move(velocity);

        if (velocity.y > Physics.gravity.y && !characterController.isGrounded) { 
            velocity.y -= fallingSpeed * Time.deltaTime;
            //canJump = false;
        }
        if (characterController.isGrounded) {
            velocity.y = 0f;
            canJump = true;
        }
      

        // movementscript.Velocity = vel;
    }
    public void JumpInput(InputAction.CallbackContext ctx)
    {
        // if(ctx().action.phase == InputActionPhase.Performed && ctx.action.phase == InputActionPhase.Canceled)
       //Debug.Log("phase" + ctx.action.phase);



        if(ctx.action.phase == InputActionPhase.Started)
        {
            jumpPressed = true;
            velocity.y = 0f;


            //todo coroutine met 1 sec max en dan jumppressed false zetten
            StartCoroutine(JumpTimeUp());


            //movementscript.VelY = jumpForce;
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
