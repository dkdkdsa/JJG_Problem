using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Show : MonoBehaviour
{

    [SerializeField] private TMP_Text text;
    [SerializeField] private TMP_Text jangDabText;
    [SerializeField] private TMP_InputField inputField;
    [SerializeField] private ExamQuestions exam;

    private int dabCt;
    private bool isEnd;

    private void Start()
    {

        Debug.Log(2 % 3);

        StartCoroutine(ExamCo());

    }

    public void SetIsend()
    {

        isEnd = true;

    }

    private void Update()
    {
        
        jangDabText.text = dabCt.ToString();

    }

    private IEnumerator ExamCo()
    {

        while (true) 
        {

            string value = "";
            if(Random.Range(0, 2) == 0)
            {

                var q = exam.pluralQus[Random.Range(0, exam.pluralQus.Count)];
                text.text = q.qus += "\n\n";
                
                for(int i = 0; i < q.selects.Count; i++)
                {

                    text.text += $"{i + 1} : " + q.selects[i] + "\n";

                }


                value = q.answer;

            }
            else
            {

                var q = exam.subjectivityQus[Random.Range(0, exam.subjectivityQus.Count)];
                text.text = q.qus += "\n\n";

                value = q.answer;

            }

            yield return new WaitUntil(() => isEnd);
            isEnd = false;
            if(inputField.text == value)
            {

                dabCt++;
                Debug.Log("정답");

            }
            else
            {

                Debug.Log("답은 : " + value);

            }

            yield return new WaitForSeconds(2f);

            text.text = "";

        }

    }

}
