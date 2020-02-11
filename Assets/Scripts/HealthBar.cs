﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class HealthBar : MonoBehaviour
{

    public Transform bar;
    public TextMeshProUGUI txtHealth;
    public float startingHealth;
    public float currentHealth;
    private float maxHealth = 100;

    private void Start()
    {
        startingHealth = 100;
        currentHealth = startingHealth;
        bar = transform.Find("Bar");
        setHealth(currentHealth);
        displayHealth();
    }

    public void setSize(float sizeNormalized)
    {
        bar.localScale = new Vector3(sizeNormalized, .54f);
    }

    public void setColor(Color color)
    {
        bar.Find("BarSprite").GetComponent<SpriteRenderer>().color = color;
    }

    public void setHealth(float health)
    {
        currentHealth = health;
        displayHealth();
        setSize(health * 0.01f);
    }

    public void displayHealth()
    {
        txtHealth.text = ((int)currentHealth).ToString();
    }

    public float getHealth()
    {
        return currentHealth;
    }

    public void doDamage(float dmg)
    {
        if (currentHealth - dmg <= 0)
        {
            setHealth(0);
        }
        else
        {
            setHealth(currentHealth - dmg);
            if (currentHealth <= (startingHealth * 0.25))
                setColor(Color.red);
        }
    }
    public void doRepair(float repair)
    {
        if (currentHealth + repair >= maxHealth)
        {
            setHealth(currentHealth + repair);
            Debug.Log("Ship repaired");
        }
        else
        {
            setHealth(currentHealth + repair);
        }
    }

    private void Update()
    {
        doDamage(80);
    }
}

