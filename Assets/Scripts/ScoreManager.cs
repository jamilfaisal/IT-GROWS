using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int playerScore = 0;
    public Text scoreText;
    public UpdateScore updater;
    //public Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        playerScore = 0;
    }
    private void Update()
    {
        if (playerScore > 1999) { 
        }
    }
    // Update is called once per frame
    void addScore(int scoreObtained)
    {
        playerScore += scoreObtained;
        updater.UpdateScoreText(playerScore);
        //UpdateScore.Update
    }
}
