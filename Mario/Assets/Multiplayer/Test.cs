using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class Test : MonoBehaviour
{
    private enum Colors
    {
        Black,
        White,
        Blue,
    }
    private Colors currentrace;
    // Start is called before the first frame update
    void Start()
    {
        colorchecker(Colors.White);
    }
    void colorchecker(Colors color)
    {
        currentrace = color;
        if (currentrace == Colors.White)
        {
            Debug.Log("you are white");
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    public void MoveInput(InputAction.CallbackContext ctx) {
        //Debug.Log(ctx.ReadValue<Vector2>().x);
        //Debug.Log(ctx.ReadValue<Vector2>().y);
    }
    public void JumpInput(InputAction.CallbackContext ctx)
    {
        Debug.Log("i jumped");
    }
    public void GroundPoundInput(InputAction.CallbackContext ctx)
    {
        Debug.Log("i pound");
    }
    public void AttackInput(InputAction.CallbackContext ctx)
    {
        Debug.Log("i attec");
    }
}
