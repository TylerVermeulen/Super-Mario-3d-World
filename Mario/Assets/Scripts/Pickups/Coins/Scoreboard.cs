using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class Scoreboard : MonoBehaviour
{
    private int score = 22;
    private int points = +1;
    [SerializeField]
    private TMP_Text textField;

    void Start()
    {
        Pickup.OnPickup += UpdateScore;
    }

    private void UpdateScore()
    {
        score += points;
        textField.text = "X" + score;
    }
}
