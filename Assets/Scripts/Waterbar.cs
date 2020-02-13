using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Waterbar : MonoBehaviour
{
    public HealthBar waterBar;
    void Start()
    {
        waterBar.startingHealth = 100;
        waterBar.currentHealth = 100;
        waterBar.setHealth(waterBar.currentHealth);
    }
    void Update()
    {
    }
}
