using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerHandler : MonoBehaviour
{
    public HealthBar health;
    public GameObject playerTimer;
    public GameObject arrow;
    public SoundHandler sounds;
    public float timer = 10f;
    private bool endtimer = false;
    private bool arrowtimer = false;
    private float playedTime = 0;
    void Start()
    {
        health.startingHealth = 100;
        health.currentHealth = 100;
        health.setHealth(health.currentHealth);
    }

    private void FixedUpdate()
    {
        if (endtimer == true)
        {
            if (timer > 0)
            {
                timer -= 1f * Time.fixedDeltaTime;
                if (timer <= 0)
                    sounds.burningPlayerSound.Play(0);
            }
            if (timer <= 0)
            {
                playerTimer.SetActive(true);
                arrowtimer = true;
                health.doDamage(0.10f);
            }
        }
    }
    void Update()
    {
        playedTime += Time.deltaTime;
        if ((int)playedTime == 7 && playerTimer.activeSelf == false)
        {
            endtimer = true;
        }
        if (arrowtimer == true && arrow.activeSelf == false && playedTime < 20)
        {
            arrow.SetActive(true);
        }
        if ((int)playedTime == 27)
        {
            arrow.SetActive(false);
        }
        if (health.dead == true)
        {
            DataCollector.Death = "You died";
            SceneManager.LoadScene("EndGameScreen", LoadSceneMode.Single);
        }
    }
}
