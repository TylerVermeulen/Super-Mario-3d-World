using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AnimationsControls : MonoBehaviour
{
    private Vector2 moveinput;


    [SerializeField] private float walkSpeed;
    [SerializeField] private float speed;
    [SerializeField] private float sprintSpeed;

    Animator animator;
    private CharacterController controller;


    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        controller = GetComponent<CharacterController>();
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
            Debug.Log("Walk Animation");
        }
        moveinput.x = ctx.ReadValue<Vector2>().x;
        moveinput.y = ctx.ReadValue<Vector2>().y;

        if (ctx.action.phase == InputActionPhase.Canceled)
        {
            animator.SetTrigger("Idle");
            animator.ResetTrigger("Walking");
        }
    }

    /*public void JumpInput(InputAction.CallbackContext ctx)
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
    }*/


    /*public void SprintInput(InputAction.CallbackContext ctx)
    {
        if (ctx.action.phase == InputActionPhase.Performed)
        {
            animator.SetTrigger("Walking");
            Debug.Log("jdagwhidb");
        }
        if (ctx.action.phase == InputActionPhase.Canceled)
        {
            speed = walkSpeed;
        }
    }*/

}
