using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{   //coin
    public static Action OnPickup;

    private int coinScore = 1;
    private Score score = null;

    [SerializeField]
    private AudioSource audio;
    void Start()
    {
        score = FindAnyObjectByType<Score>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") 
        {
            audio.Play();
            OnPickup?.Invoke();
            Destroy(gameObject, 1);
            GetComponent<MeshRenderer>().enabled = false;
            Score.updateScore += coinScore;
            score.HandleScore();

        }
    }
}
