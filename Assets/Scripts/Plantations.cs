using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plantations : MonoBehaviour
{
    public HealthBar healthBar;

    private void Start()
    {
        healthBar.startingHealth = 100;
        healthBar.currentHealth = 100;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log("Enter");
    }

    private void Update()
    {
        healthBar.doDamage(0.01f);
        if (healthBar.dead)
        {
            //Debug.Log("Dead");
        }
    }
}
