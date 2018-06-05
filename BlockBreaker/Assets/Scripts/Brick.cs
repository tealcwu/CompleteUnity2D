using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {

    public Sprite[] hitSprites;
    public AudioClip crack;
    private int maxHit;
    private int timesHit;
    public static  int breakableCount = 0;
    private bool isBreakable;
    private LevelManager levelManager;

	// Use this for initialization
	void Start () {
        isBreakable = gameObject.CompareTag("Breakable");

        if(isBreakable)
        {
            breakableCount++;
            print(breakableCount);
        }

        timesHit = 0;
        maxHit = hitSprites.Length + 1;
        levelManager = GameObject.FindObjectOfType<LevelManager>();
	}
	
	// Update is called once per frame
	void Update () {

	}

    void LoadSprite()
    {
        int spriteIndex = timesHit - 1;
        if(hitSprites[spriteIndex])
        {
            this.GetComponent<SpriteRenderer>().sprite = hitSprites[spriteIndex];
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        AudioSource.PlayClipAtPoint(crack, transform.position);
        if(isBreakable)
        {
            handleHits();
        }
    }

    void handleHits()
    {
        timesHit++;

        if (timesHit >= maxHit)
        {
            breakableCount--;
            levelManager.BrickDestroyed();
            Destroy(gameObject);
        }
        else
        {
            LoadSprite();
        }
    }

    void SimulateWin()
    {
        print("YOU WIN!");
        levelManager.LoadNextLevel();
    }
}
