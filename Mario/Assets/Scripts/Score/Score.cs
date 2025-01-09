using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] private TMP_Text score;

    private int startScore = 013600;
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
    }

    
}
