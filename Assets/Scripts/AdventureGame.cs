using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{

    [SerializeField] Text textComponent;
    [SerializeField] States startingState;

    int[] oddnumbers = { 1, 3, 5, 7, 9 }; 

    States state;

    // Start is called before the first frame update
    void Start()
    {
        state = startingState;
        textComponent.text = state.GetStateStory();
        Debug.Log(oddnumbers[3]);
    }

    // Update is called once per frame
    void Update()
    {
        ManageState();
    }

    private void ManageState()
    {
        var nextState = state.GetNextStates();

        for (int i = 0; i < nextState.Length;i++)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1 + i))
            {
                state = nextState[i];
            }
        }

        textComponent.text = state.GetStateStory();
    }
}
