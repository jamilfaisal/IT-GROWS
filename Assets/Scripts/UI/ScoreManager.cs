using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public int playerScore = 0;
    public int scoreToWin;
    public TMP_Text playerScoreText;
    public GameManager GameManager;

    private void Start() {
        playerScoreText.text = "Score: " + playerScore.ToString();
    }

    private void Update() {
        playerScoreText.text = "Score: " + playerScore.ToString();
        if (playerScore > scoreToWin) {
            GameManager.EndGame(true);
        }
    }

    public void UpdateScore(int scoreObtained)
    {
        playerScore += scoreObtained;
    }
}
