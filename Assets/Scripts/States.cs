using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "States")]

public class States : ScriptableObject
{
    [TextArea(14,10)] [SerializeField] string storyText;
    [SerializeField] States[] nextStates;
    [SerializeField] StatesNumber[] numberStates;

    public string GetStateStory()
    {
        return storyText;
    }

    public States[] GetNextStates()
    {
        return nextStates;
    }
}
