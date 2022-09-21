using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    
    public GameObject gameWonText;
    public GameObject gameLostText;

    public void EndGame(bool win) {
        if (win) {
            gameWonText.SetActive(true);
        } else {
            gameLostText.SetActive(true);
        }
        Time.timeScale = 0;
    }
}
