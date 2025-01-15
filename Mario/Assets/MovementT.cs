using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementT : MonoBehaviour
{
    private Rigidbody rb;

    [SerializeField] private float playerSpeed = 10f;
    [SerializeField] private float jump = 500.0f;

    Animator animator;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();    
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalMove = Input.GetAxis("Horizontal");
        float verticalMove = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(horizontalMove, 0, verticalMove);
        move *= Time.deltaTime * playerSpeed;
        transform.position += new Vector3(move.x, 0, move.z);

        if (Input.GetKeyDown("space"))
        {
            rb.AddForce(transform.up * jump);
            Debug.Log("Jump");
        }

        if (Input.GetKey(KeyCode.W))
        {
            animator.ResetTrigger("Idle");

            animator.SetTrigger("Walking"); 
        }

        if (Input.GetKey(KeyCode.Space))
        {
            animator.ResetTrigger("Walking");

            animator.SetTrigger("Jumping");
        }
    }
}
