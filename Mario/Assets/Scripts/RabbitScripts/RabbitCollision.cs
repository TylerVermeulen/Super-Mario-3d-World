using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class RabbitCollision : MonoBehaviour
{
    [SerializeField] private GameObject star;
    private Animator animator;
    private bool spawnin;
    // Start is called before the first frame update
    void Start()
    {
        spawnin = false;
        star.SetActive(false);
        animator = GetComponent<Animator>();
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
            star.SetActive(true);
            StartCoroutine(SpawnStar());
        }
    }
    private IEnumerator SpawnStar()
    {
        yield return new WaitForSeconds(2);
        
        Destroy(gameObject);
    }

}
