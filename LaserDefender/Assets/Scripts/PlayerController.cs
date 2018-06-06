using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    private Rigidbody2D rb2d;

    public float speed = 8;
	// Use this for initialization
	void Start () {
        rb2d = gameObject.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		
        if(Input.GetKey(KeyCode.UpArrow))
        {
            rb2d.transform.Translate(new Vector3(0f, speed * Time.deltaTime,0f));
        }

        if(Input.GetKey(KeyCode.DownArrow))
        {
            rb2d.transform.Translate(new Vector3(0f, -speed * Time.deltaTime, 0f));
        }

        if(Input.GetKey(KeyCode.LeftArrow))
        {
            rb2d.transform.Translate(new Vector3(-speed * Time.deltaTime,0f, 0f));
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb2d.transform.Translate(new Vector3(speed * Time.deltaTime, 0f, 0f));
        }
    }
}
