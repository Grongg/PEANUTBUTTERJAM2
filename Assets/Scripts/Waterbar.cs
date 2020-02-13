using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waterbar : MonoBehaviour
{
    public HealthBar waterBar;
    void Start()
    {
        waterBar.startingHealth = 0;
        waterBar.currentHealth = 0;
        waterBar.setHealth(waterBar.currentHealth);
    }
}
