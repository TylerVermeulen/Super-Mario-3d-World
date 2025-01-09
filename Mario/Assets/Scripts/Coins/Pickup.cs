using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{   //coin
    public static Action OnPickup;

    private int coinScore = 1;
    private Score score = null;

    void Start()
    {
        score = FindAnyObjectByType<Score>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") 
        {
            OnPickup?.Invoke();
            Destroy(gameObject);
            Score.updateScore += coinScore;
            score.HandleScore();
        }
    }
}
