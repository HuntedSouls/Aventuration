using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public static class QuestionSort
{
    public static int currentQuestion = 1;

    public static int score;
    
    public static void Set(int i)
    {
        currentQuestion = i;
    }

    public static void SetScore(int i)
    {
        score =  i;
    }
    
}
