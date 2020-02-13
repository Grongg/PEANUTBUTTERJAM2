using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Plantations : MonoBehaviour
{
    public HealthBar healthBar;
    public SoundHandler sound;
    private bool inCol = false;
    private float timer = 10f;

    private void Start()
    {
        healthBar.startingHealth = 100;
        healthBar.currentHealth = 100;
        healthBar.setHealth(healthBar.currentHealth);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        inCol = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        inCol = false;
    }

    private void FixedUpdate()
    {
        //Debug.Log(timer);
        if (timer > 0)
        {
            timer -= 1f * Time.fixedDeltaTime;
            if (timer <= 0)
                sound.burningPlantSound.Play(0);

        }
        if (timer <= 0)
            healthBar.doDamage(0.10f);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && inCol == true)
        {
            sound.arrosageSound.Play(0);
            healthBar.heal();
            timer = 10f;
        }
        if (healthBar.dead == true)
        {
            DataCollector.Death = "Plantations burned";
            SceneManager.LoadScene("EndGameScreen", LoadSceneMode.Single);
        }
    }
}
