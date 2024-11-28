using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TestInput(InputAction.CallbackContext ctx) {
        Debug.Log(ctx.ReadValue<Vector2>().x);
        Debug.Log(ctx.ReadValue<Vector2>().y);
    }
}
