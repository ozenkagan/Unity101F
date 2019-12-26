using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    int guess;
    int max;
    int min;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    void StartGame()
    {
        max = 1000;
        min = 1;
        guess = 500;
        Debug.Log("Welcome to number wizard lol");
        Debug.Log("Highest number:" + max);
        Debug.Log("Lowest number:" + min);
        Debug.Log("Higher or greater than" + guess);
        Debug.Log("Push up = higher, Push Down = lower, ");
        print("wazzzzzzup");
        max = max + 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("Down key was pressed.");
            max = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("You hit enter.");
            StartGame();

        }

    }

    void NextGuess()
    {
        guess = (max + min) / 2;
        Debug.Log("Is it higher or lower than..." + guess);
    }
}
