using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    private Rigidbody rb;

    [SerializeField] private float playerSpeed = 10f;
    [SerializeField] private float jump = 500.0f;


    void Start()
    {
        rb = GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalMove = Input.GetAxis("Horizontal");
        float verticalMove = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(horizontalMove, 0 ,verticalMove);
        transform.Translate(move * playerSpeed * Time.deltaTime);

        if (Input.GetKeyDown("space"))
        {
            rb.AddForce(transform.up * jump);
            Debug.Log("Jump");
        }
    }

  
}
