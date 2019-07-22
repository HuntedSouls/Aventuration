using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[System.Serializable]
public class QuestionDataCollection
{
    public List<QuestionData> questions;

    public static QuestionDataCollection GetQuestionData(string jsonName)
    {
        return JsonUtility.FromJson<QuestionDataCollection>(jsonName);
    }
}
