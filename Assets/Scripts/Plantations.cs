using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine;

public class Plantations : MonoBehaviour
{
    public HealthBar waterbar;
    public HealthBar healthBar;
    public GameObject E;
    public SoundHandler sound;
    public PlayerHandler player;
    private bool inCol = false;
    public float timer;
    public int timerspeed;
    public float speedup = 1f;
    public Well well;
    private void Start()
    {
        healthBar.startingHealth = 100;
        healthBar.currentHealth = 100;
        healthBar.setHealth(healthBar.currentHealth);
        //waterbar.startingHealth = 100;
        //waterbar.currentHealth = 100;
        //waterbar.setHealth(waterbar.currentHealth);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        inCol = true;
        if (E.activeSelf == false)
        {
            E.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        inCol = false;
        E.SetActive(false);
    }

    private void FixedUpdate()
    {
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
        if (Input.GetKeyDown(KeyCode.E) && inCol == true && well.wellOnce == true)
        {
            sound.arrosageSound.Play(0);
            if (waterbar.currentHealth != 0f)
            {
                healthBar.heal();
                waterbar.setHealth(waterbar.currentHealth - 10);
                timer = timerspeed * speedup;
                speedup -= 0.02f;
                player.animatewatering();
            }
        }
        if (Input.GetKeyUp(KeyCode.E) && inCol == true && well.wellOnce)
            player.animatestopwatering();
        if (healthBar.dead == true)
        {
            DataCollector.Death = "Plantations burned";
            SceneManager.LoadScene("EndGameScreen", LoadSceneMode.Single);
        }
    }
}
