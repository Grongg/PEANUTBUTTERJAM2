using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScreen : MonoBehaviour
{
    public bool up = false;
    public bool left = false;
    public float x = 0f;
    public float y = 0f;
    // Start is called before the first frame update
    void Start()
    {
    }
 
 // Update is called once per frame
    void FixedUpdate ()
    {
        if (x >= 8f)
            left = false;
        else if (x <= -8f)
            left = true;
        if (y >= 5f)
            up = true;
        else if (y <= -5f)
            up = false;
        if (up)
            y -= 0.02f;
        else
            y += 0.02f;
        if (left)
            x += 0.02f;
        else   
            x -= 0.02f;
        transform.position = new Vector3(x, y, 0);
    }
}
