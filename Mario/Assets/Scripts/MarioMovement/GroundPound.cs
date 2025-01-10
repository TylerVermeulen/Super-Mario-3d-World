using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GroundPound : MonoBehaviour
{
    [SerializeField]
    private CharacterController characterController;
    private float fallingSpeed;
    private Vector3 velocity;
    [SerializeField] private float groundpoundSpeed;
    [SerializeField] private float normalSpeed;

    // Start is called before the first frame update
    void Start()
    {
        velocity = new Vector3(0, 0, 0);
        fallingSpeed = GetComponent<Jump>().fallingspeed;
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        characterController.Move(velocity);
        if (characterController.isGrounded) 
        {
            velocity.y = -normalSpeed * Time.deltaTime;
        }
    }
    public void Groundpound() 
    {
        
        if (!characterController.isGrounded)
        {
            //Debug.Log("not on ground");
            //fallingSpeed = groundpoundSpeed;
            velocity.y = -groundpoundSpeed * Time.deltaTime;
        }
        
    }
    public void GroundPoundInput(InputAction.CallbackContext ctx)
    {
        if (ctx.action.phase == InputActionPhase.Performed)
        {
            Groundpound();
        }
        
    }
}
