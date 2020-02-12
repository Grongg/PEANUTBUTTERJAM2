using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movespeed = 5f;
    public Rigidbody2D rb;
    public Animator animator;
    public SoundHandler sounds;
    public bool toggleSound = false;
    Vector2 movement;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxis("Horizontal");
        movement.y = Input.GetAxis("Vertical");
        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);
    }
    
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * movespeed * Time.fixedDeltaTime);
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        if (animator.GetFloat("Speed") == 0f)
        {
            sounds.waterSound.loop = false;
            sounds.dirtSound.loop = false;
            sounds.grassSound.loop = false;
            sounds.roadSound.loop = false;
            toggleSound = false;
        }
        if (other.tag == "Road" && animator.GetFloat("Speed") != 0f && !toggleSound)
        {
            sounds.roadSound.loop = true;
            sounds.roadSound.Play(0);
            toggleSound = true;
        }
        else if (other.tag == "Water" && animator.GetFloat("Speed") != 0f && !toggleSound)
        {
            sounds.waterSound.loop = true;
            sounds.waterSound.Play(0);
            toggleSound = true;
        }
        else if (other.tag == "Dirt" && animator.GetFloat("Speed") != 0f && !toggleSound)
        {
            sounds.dirtSound.loop = true;
            sounds.dirtSound.Play(0);
            toggleSound = true;
        }
        else if (other.tag == "Grass" && animator.GetFloat("Speed") != 0f && !toggleSound)
        {
            sounds.grassSound.loop = true;
            sounds.grassSound.Play(0);
            toggleSound = true;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Road")
        {
            sounds.roadSound.loop = false;
            toggleSound = false;
        }
        else if (other.tag == "Water")
        {
            sounds.waterSound.loop = false;
            toggleSound = false;
        }
        else if (other.tag == "Grass")
        {
            sounds.grassSound.loop = false;
            toggleSound = false;
        }
        else if (other.tag == "Dirt")
        {
            sounds.dirtSound.loop = false;
            toggleSound = false;
        }
    }
}
