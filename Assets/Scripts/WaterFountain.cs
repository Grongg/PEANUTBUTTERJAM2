using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterFountain : MonoBehaviour
{
    public PlayerHandler Player;
    public SoundHandler sounds;


    void Update()
    {
      
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Player.health.heal();
        Player.timer = 10f;
        if (Player.health.currentHealth == 100)
            sounds.revitalized.Play(0);
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        Player.health.heal();
        Player.timer = 10f;
        if (Player.health.currentHealth == 100)
            sounds.revitalized.Play(0);
    }
}
