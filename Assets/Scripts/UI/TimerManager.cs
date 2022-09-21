using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    public float TimeLeft = 5;
    public bool TimerOn;
    public TMP_Text timerText;
    public GameManager GameManager;

    void Start()
    {
        if (TimerOn) {
            displayTime();
        }
    }

    void Update()
    {  
        if (TimerOn) {
            TimeLeft -= Time.deltaTime;
            displayTime();
            if (TimeLeft <= 0) {
                TimeLeft = 0f;
                displayTime();
                TimerOn = false;
                GameManager.EndGame(false);
            }
        }
    }

    private void displayTime() {
        float minutes = Mathf.FloorToInt(TimeLeft / 60);  
        float seconds = Mathf.FloorToInt(TimeLeft % 60);
        timerText.text = "Time Left: " + string.Format("{0:00}:{1:00}", minutes, seconds) + "s";
    }

}
