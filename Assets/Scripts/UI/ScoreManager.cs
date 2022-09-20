using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int playerScore = 0;
    public Text scoreText;
    public UpdateScore updater;

    // Update is called once per frame
    private void Update()
    {
        if (playerScore > 1999) { 
        }
    }

    public void UpdateScore(int scoreObtained)
    {
        playerScore += scoreObtained;
        updater.UpdateScoreText(playerScore);
    }
}
