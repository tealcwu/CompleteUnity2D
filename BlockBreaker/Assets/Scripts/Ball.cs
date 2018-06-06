using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private Paddle paddle;
    private Vector3 paddleToBallVector;
    private Rigidbody2D rb2d;
    private bool hasStarted;
    private AudioSource audio;

    // Use this for initialization
    void Start()
    {
        paddle = GameObject.FindObjectOfType<Paddle>();
        paddleToBallVector = this.transform.position - paddle.transform.position;
        rb2d = GetComponent<Rigidbody2D>();
        audio = this.gameObject.GetComponent<AudioSource>();
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

    void OnCollisionEnter2D(Collision2D collision)
    {
        Vector2 tweak = new Vector2(Random.Range(0.1f, 0.5f), Random.Range(0.2f, 1.0f));

        if(hasStarted)
        {
            if(collision.gameObject.CompareTag("Paddle"))
            {
                audio.Play();
            }

            rb2d.velocity += tweak;
        }
    }
}