using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
    int max = 1000;
    int min = 1;
    int guess = 500;
    public int maxGuessesAllowed = 5;
    public Text text;

    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        max++;
        NextGuess();
    }
    
    public void GuessHigher()
    {
        min = guess;
        NextGuess();
    }

    public void GuessLower()
    {
        max = guess;
        NextGuess();
    }

    public void NextGuess()
    {
        guess = Random.Range(min, max + 1);
        text.text = guess.ToString();

        maxGuessesAllowed--;
        if(maxGuessesAllowed<=0)
        {
            SceneManager.LoadScene("Win");
        }
    }
}
