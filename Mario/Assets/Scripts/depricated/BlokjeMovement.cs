using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlokjeMovement : MonoBehaviour
{
    [SerializeField]
    public GameObject Blokje;
    [SerializeField]
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    public void Move()
    {

        Vector3 Movement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        Blokje.transform.position += Movement * speed * Time.deltaTime;

    }
}
