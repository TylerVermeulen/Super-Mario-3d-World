using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class RabbitCollision : MonoBehaviour
{
    [SerializeField] private GameObject star;
    private Animator animator;
    private Vector3 location;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        location = new Vector3(13.75f, 12.62f, -80.72f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.tag == "Player")
        {
            animator.SetTrigger("Touched");
            StartCoroutine(SpawnStar());
        }
    }
    private IEnumerator SpawnStar()
    {
        
        yield return new WaitForSeconds(2);
        Instantiate(star, location, Quaternion.Euler(0, -90, 0));
        Destroy(animator.gameObject);
    }

}
