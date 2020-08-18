﻿using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Pin : MonoBehaviour
{
    private bool isPinned = false;
    public float speed = 20f;
    public Rigidbody2D rb;

    private void Update()
    {
        if(!isPinned)
        rb.MovePosition(rb.position + Vector2.up * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Rotator"))
        {
            transform.SetParent(collision.transform);
            Score.PinCount++;
            isPinned = true;
        }

        else if (collision.CompareTag("Pin"))
        {
            //END GAME
            FindObjectOfType<Manager>().EndGame();
        }
    }

}
