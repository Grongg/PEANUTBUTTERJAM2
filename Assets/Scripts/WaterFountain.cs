using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterFountain : MonoBehaviour
{
    public PlayerHandler Player;


    void Update()
    {
      
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Player.health.heal();
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
       Player.health.heal();
    }
}
