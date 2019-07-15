using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AtackControler : MonoBehaviour
{
    public GameObject boss;
    float speed = 5.0f;
    private Vector3 target;
    private Vector3 startPos;
    public Text atackText;

    bool isAtacking=false;
    bool isShowDialogue = false;

    public GameObject answerDialogue;
    public float dialogueShowTime = 3.0f;

    IEnumerator AttackAnim()
    {
        answerDialogue.SetActive(false);
        isShowDialogue = false;
        isAtacking = true;
        target = boss.transform.position - new Vector3(2, -1f);
        startPos = transform.position;
        Debug.Log(target);
        Debug.Log(startPos);
        float step = speed * Time.deltaTime;

        while (transform.position != target)
        {
            Debug.Log(transform.position);
            transform.localPosition = Vector3.MoveTowards(transform.position, target, step);
            yield return new WaitForEndOfFrame();

        }
        if (CompareTag("CorrectHero"))
        {
            atackText.text = "Acertei";
        }
        else
        {
            atackText.text = "ERROU!";
        }
        target = startPos;
        while (transform.position != target)
        {
            Debug.Log(transform.position);
            transform.localPosition = Vector3.MoveTowards(transform.position, target, step);
            yield return new WaitForEndOfFrame();
        }
        atackText.text = "";
        yield return null;
        isAtacking = false;
    }

    IEnumerator ShowDialogue()
    {
        isShowDialogue = true;
        answerDialogue.SetActive(true);
        yield return new WaitForSecondsRealtime(dialogueShowTime);
        answerDialogue.SetActive(false);
        isShowDialogue = false;

    }
    // Start is called before the first frame update
    void Start()
    {
        tag = "CorrectHero";
    }

    // Update is called once per frame
    void Update()
    {
        
            
    }
    void OnMouseDown()
    {
        if(FindObjectOfType<QuestionControler>().isShowing==false && isAtacking==false && isShowDialogue==true)
            StartCoroutine(AttackAnim());


        if (FindObjectOfType<QuestionControler>().isShowing == false && isAtacking == false && isShowDialogue==false)
        {
            StartCoroutine(ShowDialogue());
        }
    }
}
