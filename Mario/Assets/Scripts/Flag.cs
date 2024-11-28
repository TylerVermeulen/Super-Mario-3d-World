using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flag : MonoBehaviour
{
    private MeshRenderer Renderer;
    [SerializeField]private Material MarioMaterial;
    // Start is called before the first frame update
    private void Awake()
    {
        Renderer = GetComponent<MeshRenderer>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            this.Renderer.material = MarioMaterial;
        }
    }
}
