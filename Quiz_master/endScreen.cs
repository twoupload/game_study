using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class endScreen : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI finalScoreText;
    ScoreKeeper scoreKeeper;
    void Start()
    {
        scoreKeeper = FindObjectOfType<ScoreKeeper>();
    }

    public void ShowFinalScore()
    {
        finalScoreText.text = "Congratulations!\nYou got a score of " + 
                                scoreKeeper.CalculateScore() + "%";
    }

}
