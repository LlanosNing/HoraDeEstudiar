using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObject/State")]
public class State : ScriptableObject
{
    [TextArea(14, 10)] [SerializeField] string StoryText;
    [SerializeField] State[] nextStates;

    public string GetStateStoryText()
    {
        return StoryText;
    }

    public State[] GetNextStates()
    {
        return nextStates;
    }
}