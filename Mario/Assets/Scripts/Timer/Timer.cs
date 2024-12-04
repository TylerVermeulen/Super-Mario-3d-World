using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField]
    private float time = 439f;
    private bool timerRunning = false;
    [SerializeField] private TMP_Text timertext;
    // Start is called before the first frame update
    void Start()
    {
        timerRunning = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (timerRunning == true)
        {
            if (time > 0)
            {
                time -= Time.deltaTime;
            }
            else 
            {
                Debug.Log("No more time");
                time = 0f;
                timerRunning = false;
            }
        }
        // maxLength
        timertext.text = time.ToString();
        Debug.Log(time);
    }
}
