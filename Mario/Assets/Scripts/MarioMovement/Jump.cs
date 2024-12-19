using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Jump : MonoBehaviour
{
    private MovementT movementscript;
    private Vector3 vel;
    [SerializeField] private float fallingSpeed;
    [SerializeField] private float jumpForce;
    public MovementT Movementscript
    {
        set {  movementscript = value; }
    }

    // Start is called before the first frame update
    void Start()
    {
        Movementscript = this.GetComponent<MovementT>();
        vel = movementscript.Velocity;
    }

    // Update is called once per frame
    void Update()
    {
        if(vel.y > Physics.gravity.y)
        {
            vel.y -= fallingSpeed;
        }
        
        movementscript.Velocity = vel;
    }
    public void JumpInput(InputAction.CallbackContext ctx)
    {
        if(ctx.action.phase == InputActionPhase.Performed)
        {
            vel.y = jumpForce;
        }
    }
}
