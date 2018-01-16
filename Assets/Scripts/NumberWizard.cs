using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class NumberWizard : MonoBehaviour {
    public static int high = 1000;
    private static int low;
    private static bool numFound;
    private static int counter;
    private static int bracket = high;
    int maxGuesses = (int)Mathf.Log(bracket, 2);
    public Text numGuess;
    public Text numOfTries;
    public Text counterOfTries;

    // Use this for initialization
    void Start () {
        print(maxGuesses);
        startGame();
	}


    // Update is called once per frame


    void startGame()
    {
        high = 1000;
        low = 0;
        numFound = false;
        counter = 0;
        numGuess.text = ((high - low) / 2).ToString();
        numOfTries.text = maxGuesses.ToString();

    }

    void nextGuess()
    {
        numGuess.text = (high - ((high - low) / 2)).ToString();
        counter++;
        maxGuesses--;
        numOfTries.text = maxGuesses.ToString();
        if(maxGuesses < 0)
        {
            Application.LoadLevel("Win");
            startGame();
        }

    }
    public void guessHigher()
    {
        low = (high - ((high - low) / 2));
        nextGuess();
    }

    public void guessLower()
    {
        high = (high - ((high - low) / 2));
        nextGuess();
    }
    public void counterForComputer()
    {
        counterOfTries.text = counter.ToString();
    }
}
