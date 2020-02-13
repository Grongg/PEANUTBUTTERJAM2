using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LevelHandler : MonoBehaviour
{

    private int startingLevel = 1;
    private int currentLevel;
    private int count = 0;
    public TextMeshProUGUI Leveltxt;
    public SoundHandler sounds;

    private void Start()
    {
        currentLevel = startingLevel;
        DataCollector.Score = currentLevel;
        displayLevel();
    }
    public void setLevel(int Level)
    {
        currentLevel = Level;
        DataCollector.Score = currentLevel;
        displayLevel();
    }
    private void FixedUpdate()
    {
        count +=1;
        if (count == 1000)
        {
            count = 0;
            addPoints(1);
            sounds.levelUp.Play(0);
        }
    }

    public void displayLevel()
    {
        Leveltxt.text = "Level: " + currentLevel.ToString();
    }

    public void resetLevel()
    {
        setLevel(0);
        DataCollector.Score = currentLevel;
        displayLevel();
    }

    public void addPoints(int points)
    {
        currentLevel += points;
        DataCollector.Score += points;
        displayLevel();
    }
}
