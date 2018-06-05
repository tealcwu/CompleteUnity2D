﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Paddle paddle;
    private Vector3 paddleToBallVector;
    private Rigidbody2D rb2d;
    private bool hasStarted;

    // Use this for initialization
    void Start()
    {
        paddleToBallVector = this.transform.position - paddle.transform.position;
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!hasStarted)
        {
            this.transform.position = paddle.transform.position + paddleToBallVector;

            if (Input.GetMouseButtonDown(0))
            {
                print("Mouse clicked.");
                hasStarted = true;
                rb2d.velocity = new Vector2(2f, 10f);
            }
        }
    }
}