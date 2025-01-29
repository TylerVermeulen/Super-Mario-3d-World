using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AnimationsControls : MonoBehaviour
{

    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MoveInput(InputAction.CallbackContext ctx)
    {
        if (ctx.action.phase == InputActionPhase.Performed)
        {
            animator.SetTrigger("Walking");
            
        }

        if (ctx.action.phase == InputActionPhase.Canceled)
        {
            animator.SetTrigger("Idle");
            animator.ResetTrigger("Walking");
        }
    }

    public void JumpInput(InputAction.CallbackContext ctx)
    {
        if (ctx.action.phase == InputActionPhase.Started)
        {
            animator.SetTrigger("Jumping");
            
        }
        if (ctx.action.phase == InputActionPhase.Canceled)
        {
            animator.ResetTrigger("Jumping");
            animator.SetTrigger("Idle");
        }
    }


    //public void SprintInput(InputAction.CallbackContext ctx)
    //{
    //    if (ctx.action.phase == InputActionPhase.Performed)
    //    {
    //        animator.speed = 7;
    //    }
    //    if (ctx.action.phase == InputActionPhase.Canceled)
    //    {
    //        animator.speed = 4;
    //    }
    //}

}
