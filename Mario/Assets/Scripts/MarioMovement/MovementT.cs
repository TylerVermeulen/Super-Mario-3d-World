using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MovementT : MonoBehaviour
{
    [SerializeField] private float rotationSpeed;
    [SerializeField] private float walkSpeed;
    [SerializeField] private float speed;
    [SerializeField] private float sprintSpeed;

    private Vector2 moveinput;
    private Vector3 velocity;
    private CharacterController controller;
    public Vector3 Velocity
    {
        get { return velocity; }
        set { velocity = value; }
    }

    void Awake()
    {
        controller = GetComponent<CharacterController>();
    }
    void Update()
    {
        RotateCharacter();
        MoveCharacter();
    }
    public void RotateCharacter()
    {
        if (moveinput != Vector2.zero)
        {
            Vector3 moveDirection = new Vector3(moveinput.x, 0, moveinput.y);

            Quaternion toRotation = Quaternion.LookRotation(moveDirection, Vector3.up);

            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
        }
    }
    public void MoveCharacter()
    {
        float holdY = Velocity.y;
        float moveSpeed = speed * moveinput.magnitude;
        velocity = transform.forward * moveSpeed * Time.deltaTime;
        //velocity.y = Physics.gravity.y;
        controller.Move(Velocity * Time.deltaTime);
        velocity.y = holdY;
    }

    public void MoveInput(InputAction.CallbackContext ctx)
    {
        moveinput.x = ctx.ReadValue<Vector2>().x;
        moveinput.y = ctx.ReadValue<Vector2>().y;
    }
    public void SprintInput(InputAction.CallbackContext ctx)
    {
        if (ctx.action.phase == InputActionPhase.Performed)
        {
            speed = sprintSpeed;
        }
        if (ctx.action.phase == InputActionPhase.Canceled)
        {
            speed = walkSpeed;
        }
    }
}
