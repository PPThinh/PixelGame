using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "NewStoryScene", menuName = "Data/NewStoryScene")]
[System.Serializable]
public class StoryScene : ScriptableObject
{
    public List<Sentence> sentences;
    public Sprite backGround;
    public StoryScene nextScene;

    [System.Serializable]

    public struct Sentence
    {
        public string text;
        public Speaker speaker;
    }
}