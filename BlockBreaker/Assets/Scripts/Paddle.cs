using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 paddlePos = new Vector3(0.5f, this.transform.position.y, -5.0f);
        float mousePosInBlocks = Input.mousePosition.x / Screen.width * 16 - 8;
        //print(mousePosInBlocks);
        //print(Input.mousePosition.x);
        paddlePos.x = mousePosInBlocks;
       this.transform.position = paddlePos;
	}
}
