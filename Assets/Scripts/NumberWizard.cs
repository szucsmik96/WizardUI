using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour {
    int max;
    int min;
    int guess;
    int maxGuesses = 12;
    public Text text;
    void StartGame()
    {
        max = 10000;
        min = 1;
        NextGuess();
    }
    void NextGuess()
    {
        guess = Random.Range(min, max+1);
        text.text = guess.ToString();
        maxGuesses--;
        if (maxGuesses <= 0)
        {
            Application.LoadLevel("Win");
        }
    }
    // Use this for initialization
    void Start () {
        StartGame();
	}
	
    public void GuessLower(){
            max = guess;
            NextGuess();
    }
    public void GuessHigher(){
        min = guess;
        NextGuess();
    }
    public void Correct()
    {
        Application.LoadLevel("Lose");
    }
}
