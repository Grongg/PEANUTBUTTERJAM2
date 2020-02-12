using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class HealthBar : MonoBehaviour
{

    public Transform bar;
    public float startingHealth = 100;
    public float currentHealth = 100;
    public bool dead = false;

    private void Start()
    {
        currentHealth = startingHealth;
        bar = transform.Find("Bar");
        doDamage(0);
    }

    public void setSize(float sizeNormalized)
    {
        bar.localScale = new Vector3(sizeNormalized, 1f);
    }

    public void setColor(Color color)
    {
        bar.Find("BarSprite").GetComponent<SpriteRenderer>().color = color;
    }

    public void setHealth(float health)
    {
        currentHealth = health;
        setSize(health * 0.01f);
    }

    public void doDamage(float dmg)
    {
        if (currentHealth - dmg <= 0)
        {
            setHealth(0);
            dead = true;
        }
        else
        {
            setHealth(currentHealth - dmg);
            if (currentHealth <= (startingHealth * 0.25))
                setColor(Color.red);
        }
    }
}

