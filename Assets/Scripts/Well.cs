using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Well : MonoBehaviour
{
    public GameObject E;
    public HealthBar waterbar;
    private bool inCol = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        inCol = true;
        if (E.activeSelf == false && collision.tag == "Player")
        {
            E.SetActive(true);
        }
            
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        inCol = false;
        E.SetActive(false);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && inCol == true)
        {
            //sound.arrosageSound.Play(0);
            waterbar.setHealth(100);
        }
    }
}
