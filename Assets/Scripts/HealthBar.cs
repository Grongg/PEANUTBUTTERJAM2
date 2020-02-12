using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class HealthBar : MonoBehaviour
{

    public Transform bar;
    public float startingHealth;
    public float currentHealth;
    public bool dead = false;

    private void Start()
    {
        bar = transform.Find("Bar");
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
    public void heal()
    {
        if (currentHealth != 100)
        {
            if ((currentHealth + 0.10f) > (startingHealth * 0.25))
            {
                Color newColor = new Color(0, 120, 19, 255);
            }
            if (currentHealth + 0.10f <= 100)
            {
                setHealth(currentHealth + 0.60f);
            }
        }
    }
}

