using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThermometerHandler : MonoBehaviour
{
    // Start is called before the first frame update
    public HealthBar thermometerBar;
    public float timer = 0;
    void Start()
    {
        thermometerBar.currentHealth = 0;
        thermometerBar.setHealth(thermometerBar.currentHealth);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        timer += 0.02f;
        if (timer >= 5f)
        {
            if (thermometerBar.currentHealth != 100)           
                thermometerBar.currentHealth += 1;
            thermometerBar.setHealth(thermometerBar.currentHealth);
            timer = 0f;
        }
    }
}
