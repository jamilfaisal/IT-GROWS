using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float TimeLeft = 80;
    public bool TimerOn = false;
    public Text TimerTxt;

    void Start()
    {
        TimerOn = true;
        TimerTxt = GetComponent<Text>();
        TimerTxt.text = "Time left is " + TimeLeft;
    }

    void Update()
    {
        if (TimerOn)
        {
            if (TimeLeft > 0) 
            { 
                TimeLeft -= Time.deltaTime;
                updateTimer(TimeLeft);
            }
           
        }
        else
        {
            Debug.Log("Time UP!");
            TimeLeft = 0;
            TimerOn = false;
        }
    }

    void updateTimer(float currentTime) {
        currentTime += 1;
        float minutes = Mathf.FloorToInt(currentTime / 60);
        float seconds = Mathf.FloorToInt(currentTime % 60);

        TimerTxt.text = string.Format("{0:00} : {1:00}", minutes, seconds);
    }

}
