using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    int guess = 500;
    int max = 1000;
    int min = 1;

    // Start is called before the first frame update
    void Start()
    {
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
            guess = (max + min) / 2;
            Debug.Log("Is it higher or lower than..." + guess);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("Down key was pressed.");
            max = guess;
            guess = (max + min) / 2;
            Debug.Log(guess);
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("You hit enter.");

        }

    }
}
