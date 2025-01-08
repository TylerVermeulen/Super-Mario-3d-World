using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{ //coin
    public static Action OnPickup;

    private int coinScore = 1;
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
            OnPickup?.Invoke();
            Destroy(gameObject);
            Score.updateScore += coinScore;
            score.HandleScore();
        }
        Debug.Log("Trigger");
    }
}
