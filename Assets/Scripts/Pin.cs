﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour {

    private bool isPinned = false;
    private bool isEnd = false;

    public float speed = 20f;
    public Rigidbody2D rb;

    void Update ()
    {
        if (!isPinned)
        {
            rb.MovePosition(rb.position + Vector2.up * speed * Time.deltaTime);
        }
	}

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Pin")
        {
            FindObjectOfType<GameManager>().EndGame();
            isEnd = true;
        }
        if (col.tag == "Rotator")
        {
            transform.SetParent(col.transform);
            isPinned = true;
            Invoke("AddPoint", 0.05f);
        }        
    }

    void AddPoint()
    {
        if (!isEnd)
            Score.score++;
    }
}
