using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RabbitCollision : MonoBehaviour
{
    [SerializeField] private GameObject star;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.tag == "Player")
        {
            SpawnStar();
        }
    }
    private void SpawnStar()
    {
        Instantiate(star, this.transform.position, Quaternion.identity);
        Debug.Log("Play animation here");
        Destroy(this.gameObject);
    }
}
