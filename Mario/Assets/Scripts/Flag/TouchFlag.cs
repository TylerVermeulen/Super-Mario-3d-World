using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchFlag : MonoBehaviour
{
    private int vlagscore = 2000;
    private Score score = null;
    private bool hasRun = false;

    void Start()
    {
        score = FindAnyObjectByType<Score>();
    }

    private void OnTriggerEnter(Collider other)
    {
            if (other.tag == "Player")
            {
                if (hasRun == false)
                {
                    //animatie aanroepen vlag naar beneden/ vlag veranderen
                    Score.updateScore += vlagscore;
                    score.HandleScore();
                    hasRun = true;
                }
            }
        
        
    }
}
