using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float TimeLeft = 3;
    public bool TimerOn = false;
    public Text TimerTxt;
    public bool gameEnded;
    public Text gameHasEnded;
    void Start()
    {
        gameEnded = false;
        TimerOn = true;
        gameHasEnded = GameObject.Find("gameHasEnded").GetComponent<Text>();
        gameHasEnded.enabled = false;
        TimerTxt = GetComponent<Text>();
        TimerTxt.text = "Time left is " + TimeLeft;
    }

    void Update()
    {   
       if (gameEnded)
        {
            gameHasEnded.enabled = true;
            TimerOn = false;
            gameHasEnded.text = "You Lost! Time out :(";
            Time.timeScale = 0;
        }
        if (TimerOn)
        {
            if (TimeLeft > 0)
            {
                TimeLeft -= Time.deltaTime;
                updateTimer(TimeLeft);
            }
            else {
                TimerOn = false;
            }
           
        }
        else
        {
            Debug.Log("Time UP!");
            TimeLeft = 0;
            TimerOn = false;
            gameEnded = true;
            gameHasEnded.enabled = true;
            TimerOn = false;
            gameHasEnded.text = "You Lost! Time out :(";
            Time.timeScale = 0;
        }
    }

    void updateTimer(float currentTime) {
        currentTime += 1;
        float minutes = Mathf.FloorToInt(currentTime / 60);
        float seconds = Mathf.FloorToInt(currentTime % 60);

        TimerTxt.text = string.Format("{0:00} : {1:00}", minutes, seconds);
    }

}
