using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour {

    static MusicPlayer instance = null;

    void Awake()
    {
        Debug.Log("Music Player Awake " + GetInstanceID());
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            GameObject.DontDestroyOnLoad(gameObject);
        }
    }

	// Use this for initialization
	void Start () {
        Debug.Log("Music Player Start " + GetInstanceID());

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
