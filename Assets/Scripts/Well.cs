using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Well : MonoBehaviour
{
    public GameObject E;
    public HealthBar waterbar;
    public SoundHandler sound;
    private bool inCol = false;
    public bool wellOnce = false;
    private void Start()
    {
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (E.activeSelf == false && collision.tag == "Player")
        {
            inCol = true;
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
            wellOnce = true;
            waterbar.setHealth(100);
            sound.remplissageSound.Play(0);
        }
        if (Input.GetKeyUp(KeyCode.E) && inCol == true)
        {
            sound.remplissageSound.Stop();
        }
    }
}
