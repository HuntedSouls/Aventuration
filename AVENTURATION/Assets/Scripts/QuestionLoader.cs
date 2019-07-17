using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class QuestionLoader : MonoBehaviour
{
    string path;
    QuestionData question;
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
        question = QuestionData.GetQuestionData(jsonstring);
        questionText.text =  question.questionText;
        switch (question.correctAnswer)
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
        heroA.GetComponent<AtackControler>().answerDialogue.GetComponentInChildren<Text>().text = question.optionA;
        heroB.GetComponent<AtackControler>().answerDialogue.GetComponentInChildren<Text>().text = question.optionB;
        heroC.GetComponent<AtackControler>().answerDialogue.GetComponentInChildren<Text>().text = question.optionC;
        heroD.GetComponent<AtackControler>().answerDialogue.GetComponentInChildren<Text>().text = question.optionD;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
