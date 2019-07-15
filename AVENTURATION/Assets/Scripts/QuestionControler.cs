using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class QuestionControler : MonoBehaviour
{
    public Image questionBox;
    public Text bossName;
    public Text questionText;

    public float showtimequestion = 2.0f;

    public bool isShowing = false;

    IEnumerator FadeOutQuestion()
    {
        // fade out
        Debug.Log("Fade Out!");
        // loop over 1 second backwards
        for (float i = 1; i >= 0; i -= Time.deltaTime)
        {
            // set color with i as alpha
            questionBox.color = new Color(1, 1, 1, i);
            questionText.color = new Color(0, 0, 0, i);
            bossName.color = new Color(0, 0, 0, i);
            yield return null;
        }

    }

    IEnumerator FadeInQuestion()
    {
        Debug.Log("Fade IN!");
        // loop over 1 second
        for (float i = 0; i <= 1; i += Time.deltaTime)
        {
            // set color with i as alpha
            questionBox.color = new Color(1, 1, 1, i);
            questionText.color = new Color(0, 0, 0, i);
            bossName.color = new Color(0, 0, 0, i);
            yield return null;
        }
    }

    IEnumerator ShowTime(float time)
    {
        isShowing = true;
        yield return new WaitForSecondsRealtime(0.5f);
        Debug.Log("Fade IN!");
        // loop over 1 second
        for (float i = 0; i <= 1; i += Time.deltaTime)
        {
            // set color with i as alpha
            questionBox.color = new Color(1, 1, 1, i);
            questionText.color = new Color(0, 0, 0, i);
            bossName.color = new Color(0, 0, 0, i);
            yield return null;
        }
        // wait for a time
        Debug.Log("esperandu");
        yield return new WaitForSecondsRealtime(time);

        Debug.Log("Fade Out!");
        // loop over 1 second backwards
        for (float i = 1; i >= 0; i -= Time.deltaTime)
        {
            // set color with i as alpha
            questionBox.color = new Color(1, 1, 1, i);
            questionText.color = new Color(0, 0, 0, i);
            bossName.color = new Color(0, 0, 0, i);
            yield return null;
        }
        isShowing = false;
    }

    public void ShowQuestion()
    {

        //StartCoroutine(FadeInQuestion());
        if(isShowing == false)
            StartCoroutine(ShowTime(showtimequestion));
        //StartCoroutine(FadeOutQuestion());
       
    }

    // Start is called before the first frame update
    void Start()
    {
        questionBox.color = new Color(1, 1, 1, 0);
        questionText.color = new Color(0, 0, 0, 0);
        bossName.color = new Color(0, 0, 0, 0);
        ShowQuestion();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
