using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class NumberWizard : MonoBehaviour
{
    int maxGuess;
    int minGuess;
    int guess;
    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        maxGuess = 1000;
        minGuess = 1;
        guess = 500;

        Debug.Log("Welcome to Number Wizard...");
        Debug.Log("Pick a number, Don't tell me what it is");
        Debug.Log("The Lower number you can pick is " + minGuess);
        Debug.Log("The Higher number you can pick is " + maxGuess);
        Debug.Log("Tell me if your number is higher or lower than " + guess);
        Debug.Log("Push Up = Higher, Push Down = Lower, Enter = Correct");
        maxGuess = maxGuess + 1;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            minGuess = guess;
            NextGuess();
            
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            maxGuess = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Enter key is pressed...");
            Debug.Log("Boom!!! Game Finished...");
            //StartGame();
        }
    }
    void NextGuess()
    {
        guess = (maxGuess + minGuess) / 2;
        Debug.Log("is it Higher or Lower than " + guess);

    }
}
