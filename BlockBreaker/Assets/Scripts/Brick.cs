using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {

    public int maxHit;
    private int timesHit;

	// Use this for initialization
	void Start () {
        timesHit = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if(timesHit>=maxHit)
        {
            this.gameObject.SetActive(false);
        }
	}

    void OnCollisionEnter2D(Collision2D collision)
    {
        timesHit++;
        print("1 hit: "+timesHit);
    }
}
