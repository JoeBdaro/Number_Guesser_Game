using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Difficulty : MonoBehaviour {
    int numberOfTries;
    int bracket;

    public void easyMode(int bracketNumber)
        {
        numberOfTries = (int)Mathf.Log(bracketNumber, 2) /4;
        Debug.Log("numberOfTries");
        }
    public void mediumMode(int bracketNumber)
    {
        numberOfTries = (int)Mathf.Log(bracketNumber, 2) / 3;
        Debug.Log("numberOfTries");

    }
    public void hardMode(int bracketNumber)
    {
        numberOfTries = (int)Mathf.Log(bracketNumber, 2) / 2;
        Debug.Log("numberOfTries");

    }
    public void ultraMode(int bracketNumber)
    {
        numberOfTries = (int)Mathf.Log(bracketNumber, 2);
        Debug.Log("numberOfTries");

    }

    public int hundredsBrackets()
    {
        bracket = 100;
        return bracket;
    }

    public int thousandsBrackets()
    {
        bracket = 1000;
        return bracket;
    }
    public int tenThousandsBrackets()
    {
        bracket = 10000;
        return bracket;
    }
    public int hundredThousandsBrackets()
    {
        bracket = 100000;
        return bracket;
    }
    public int millionsBrackets()
    {
        bracket = 1000000;
        return bracket;
    }
}
