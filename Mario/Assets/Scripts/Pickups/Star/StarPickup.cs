using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class StarPickup : MonoBehaviour
{
    public ChangeImage ChangeImage;

    private int starScore = 4000;
    private Score score = null;

    // Start is called before the first frame update
    void Start()
    {
        score = FindAnyObjectByType<Score>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Destroy(gameObject);
            ChangeImage.Change();
            Score.updateScore += starScore;
            score.HandleScore();
        }
        Debug.Log("Star");
    }
    
}
