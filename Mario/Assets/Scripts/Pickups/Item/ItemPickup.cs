using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class ItemPickup : MonoBehaviour
{
    public ItemStorage ItemStorage;

    private int itemScore = 1000;
    private Score score = null;

    

    void Start()
    {
        score = FindAnyObjectByType<Score>();
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Destroy(gameObject);
            ItemStorage.IteminStorage();
            Score.updateScore += itemScore;
            score.HandleScore();
        }
    }
}
