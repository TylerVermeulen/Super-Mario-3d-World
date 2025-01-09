using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemStorage : MonoBehaviour
{
    [SerializeField]
    private Sprite Item;

    public float a;
    public Color color = Color.white;
    // Start is called before the first frame update
    void Start()
    {
        color.a = 0.42f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void IteminStorage()
    {
        GetComponent<Image>().sprite = Item;
    }
}
