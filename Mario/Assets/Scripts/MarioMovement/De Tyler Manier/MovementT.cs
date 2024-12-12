using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MovementT : MonoBehaviour
{
    private Vector3 velocity;
    [SerializeField]private float speed;
    private Vector2 moveinput;
    private CharacterController controller;
    [SerializeField] private float rotationspeed;
    void Awake()
    {
        controller = GetComponent<CharacterController>();
    }
    void Update()
    {
       // velocity = transform.position * moveinput.y * speed;

       // velocity.y = -9.13f;
        
        
        
        //transform.Rotate(Vector3.up, moveinput.x * Time.deltaTime * rotationspeed);

        if (moveinput != Vector2.zero)
        {
            
            Vector3 moveDirection = new Vector3(moveinput.x, 0, moveinput.y);

            
            Quaternion toRotation = Quaternion.LookRotation(moveDirection, Vector3.up);

            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationspeed * Time.deltaTime);
        }

        float moveSpeed = speed * moveinput.magnitude;

        velocity = transform.forward * moveSpeed * Time.deltaTime;
        velocity.y = Physics.gravity.y;
        Debug.Log(velocity);

        controller.Move(velocity * Time.deltaTime);

    }

    public void MoveInput(InputAction.CallbackContext ctx)
    {
        moveinput.x = ctx.ReadValue<Vector2>().x;
        moveinput.y = ctx.ReadValue<Vector2>().y;
    }
}
