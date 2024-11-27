using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class Scoreboard : MonoBehaviour
{
    private int score = 0;
    private int points = +1;
    [SerializeField]
    private TMP_Text textField;

    // Start is called before the first frame update
    void Start()
    {
        Pickup.OnPickup += UpdateScore;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void UpdateScore()
    {
        score += points;
        textField.text = "x" + score;
    }
}
