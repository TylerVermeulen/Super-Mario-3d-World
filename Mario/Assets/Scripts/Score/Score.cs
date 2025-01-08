using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] private TMP_Text score;
    [SerializeField] private GameObject coin;//1
    [SerializeField] private GameObject star;//4000
    [SerializeField] private GameObject vlag;//2000
    [SerializeField] private GameObject item;//1000

    private int coinScore = 1;
    private int starScore = 4000;
    private int vlagScore = 2000;
    private int itemScore = 1000;

    private int startScore;//0 6 getallen
    private int startPositionScore = 13600;

    void Start()
    {
        startScore = 0;
        HandleScore();
    }

    private void HandleScore() 
    {
        score.text = startScore.ToString();
        //oncollision roept HandleScore(); aan
    }
    
}
