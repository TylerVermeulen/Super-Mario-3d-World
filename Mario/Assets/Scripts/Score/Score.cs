using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] private TMP_Text score;

    //private int vlagScore = 2000;
    
    private int startScore = 013600;//0 6 getallen
    private static int currentScore;
   
    public static int updateScore

    {
        get { return currentScore; }
        set { currentScore = value; }
    }

    void Start()
    {
        score.text = startScore.ToString();
        currentScore = startScore;
    }

    public void HandleScore() 
    {
        score.text = currentScore.ToString() ;

        Debug.Log("019000");
    }

    //Eindigen op 019000
    
}
