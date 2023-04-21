﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//[CreateAssetMenu(fileName = "QuestScriptable", menuName = "QuestScriptable/Quest", order = 1)]
public class QuestionScriptable : ScriptableObject
{
    [ScriptableObjectId] public string itemId;
    [SerializeField] private string[] _answer = new string[4];
    [SerializeField] private int _rightAnswerId;
    public string[] Answer { get => _answer; }
    public int RightAnswerId { get => _rightAnswerId;}
}
