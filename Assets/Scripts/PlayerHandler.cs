using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHandler : MonoBehaviour
{
    public HealthBar health;
    void Start()
    {
        health.startingHealth = 100;
        health.currentHealth = 100;
        health.setHealth(health.currentHealth);
        //health.doDamage(70);
    }
    void Update()
    {

    }
}
