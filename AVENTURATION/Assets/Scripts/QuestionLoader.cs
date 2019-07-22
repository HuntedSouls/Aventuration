using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class QuestionLoader : MonoBehaviour
{
    string path;
    public QuestionDataCollection questions;
    public QuestionData currentQuestion;
    public Text questionText;
    public GameObject heroA;
    public GameObject heroB;
    public GameObject heroC;
    public GameObject heroD;
    


    // Start is called before the first frame update
    void Start()
    {
        path = "Assets/Questions/QuestionOne.json";
        StreamReader streamReader = new StreamReader(path);
        string jsonstring = streamReader.ReadToEnd();
        Debug.Log(jsonstring);
        questions = QuestionDataCollection.GetQuestionData(jsonstring);
        currentQuestion = questions.questions[QuestionSort.currentQuestion - 1];
        questionText.text = currentQuestion.questionText;
        switch (currentQuestion.correctAnswer)
        {
            case "A":
                heroA.tag = "CorrectHero";
                break;
            case "B":
                heroB.tag = "CorrectHero";
                break;
            case "C":
                heroC.tag = "CorrectHero";
                break;
            case "D":
                heroD.tag = "CorrectHero";
                break;
        }
        heroA.GetComponent<AtackControler>().answerDialogue.GetComponentInChildren<Text>().text = currentQuestion.optionA;
        heroB.GetComponent<AtackControler>().answerDialogue.GetComponentInChildren<Text>().text = currentQuestion.optionB;
        heroC.GetComponent<AtackControler>().answerDialogue.GetComponentInChildren<Text>().text = currentQuestion.optionC;
        heroD.GetComponent<AtackControler>().answerDialogue.GetComponentInChildren<Text>().text = currentQuestion.optionD;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
