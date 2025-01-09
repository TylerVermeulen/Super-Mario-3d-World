using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchFlag : MonoBehaviour
{
    private int vlagscore = 2000;
    private Score score = null;

    // Start is called before the first frame update
    void Start()
    {
        score = FindAnyObjectByType<Score>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            //animatie aanroepen vlag naar beneden
            Score.updateScore += vlagscore;
            score.HandleScore();
        }
    }
}
