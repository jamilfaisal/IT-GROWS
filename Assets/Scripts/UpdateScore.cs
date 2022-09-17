using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class updateScore : MonoBehaviour
{
    public GameObject playerScoreObj;
    private Text playerScore;
    // Start is called before the first frame update
    void Start()
    {
        playerScore = playerScoreObj.GetComponent<Text>();
        playerScore.text = "Score is 0";
    }

    // Update is called once per frame
    public void UpdateScoreText(int newScore)
    {
        playerScore.text = "Score is " + newScore;
    }
}
