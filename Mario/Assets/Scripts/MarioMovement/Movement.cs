using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private CharacterController characterController;
    private Vector3 playerVelocity;

    [SerializeField] private float playerSpeed = 10f;
    //[SerializeField] private float jump = 5f;
    //[SerializeField] private float gravity = -9;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        characterController.Move(move * Time.deltaTime * playerSpeed);
    }
}
