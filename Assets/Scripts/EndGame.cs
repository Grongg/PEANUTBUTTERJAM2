using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    public TextMeshProUGUI statetxt;
    public TextMeshProUGUI scoretxt;
    private void Start()
    {
        scoretxt.text = "Score: " + DataCollector.Score.ToString();
    }

    private void Update()
    {
        if (DataCollector.Death == "You died")
        {
            statetxt.text = "You died and your plantations burned";
        }
        else if (DataCollector.Death == "Plantations burned")
        {
            statetxt.text = "Your plantations burned!";
        }
    }
}
