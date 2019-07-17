using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class QuestionData
{
    public int questionNumber;
    public string questionText;
    public string optionA;
    public string optionB;
    public string optionC;
    public string optionD;
    public string correctAnswer;

    public static QuestionData GetQuestionData(string jsonName)
    {
        return JsonUtility.FromJson<QuestionData>(jsonName);
    }
    public static void CreateJSON(QuestionData data)
    {
        JsonUtility.ToJson(data);
        
    }
}
