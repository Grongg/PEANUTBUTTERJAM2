using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreHandler : MonoBehaviour
{
    private int startingScore = 0;
    private int currentScore;
    private int count = 0;
    public TextMeshProUGUI scoretxt;

    private void Start()
    {
        currentScore = startingScore;
        DataCollector.Score = currentScore;
        displayScore();
    }
    public void setScore(int score)
    {
        currentScore = score;
        DataCollector.Score = currentScore;
        displayScore();
    }
    private void FixedUpdate()
    {
        count +=1;
        if (count == 50)
        {
            count = 0;
            addPoints(10);
        }
    }

    public void displayScore()
    {
        scoretxt.text = "Score: " + currentScore.ToString();
    }

    public void resetScore()
    {
        setScore(0);
        DataCollector.Score = currentScore;
        displayScore();
    }

    public void addPoints(int points)
    {
        currentScore += points;
        DataCollector.Score += points;
        displayScore();
    }
}
