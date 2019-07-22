using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;


public class SceneControler : MonoBehaviour
{
    int currentQuestion;

    
    public void NextQuestion()
    {

        if (currentQuestion%2 == 0)
        {
            QuestionSort.Set(QuestionSort.currentQuestion += 1);
            
            SceneManager.LoadScene("BossSkeleton");
        }
        else
        {
            QuestionSort.Set(QuestionSort.currentQuestion+=1);
            
            SceneManager.LoadScene("BossBoomer");
        }
    }
    // Start is called before the first frame update..
    void Awake()
    {

        currentQuestion = QuestionSort.currentQuestion;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
