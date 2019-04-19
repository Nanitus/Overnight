using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class ChoiceScriptCop : MonoBehaviour
{
    
    float EventTimer = 5.0f;
    public bool option1 = true;
    public bool option2 = true;
    public bool HasChosen = false;
    public bool StartTimer = false;
    public GameObject TextBoxCop1;
    public GameObject TextBoxCop2;
    public GameObject TextBoxQuestionCop;
    public GameObject Choice1Cop;
    public GameObject Choice2Cop;

    void Start()
    {
        Neutral();
        MoralityAdder();
        QuestionBox();
    }
    public void QuestionBox()
    {
        TextBoxQuestionCop.GetComponent<TextMeshProUGUI>().text = "A Cop approaches your car to ask a few questions, what do you do?";
        TextBoxCop1.GetComponent<TextMeshProUGUI>().text = "Talk to him";
        TextBoxCop2.GetComponent<TextMeshProUGUI>().text = "Argue with him";
        GameManager.instance.EventNumber = GameManager.instance.EventNumber + 1;


    }


    public void Neutral()
    {

        if (GameManager.instance.ChoiceMade == 0)
        {
            GameManager.instance.Event1Checker = 3;
            SceneManager.LoadScene(2);
        }
    }

    public void MoralityAdder()
    {
        if (GameManager.instance.ChoiceMade >= 1)
        {
            GameManager.instance.moral = GameManager.instance.moral + 1;
        }
        
        if (GameManager.instance.ChoiceMade <= 1)
        {
            GameManager.instance.moral = GameManager.instance.moral - 1;
        }
    }

    public void ChoiceOption1()
    {
        if (option1 == true)
        {
            HasChosen = true;
            GameManager.instance.Event1Checker = 1;

            TextBoxQuestionCop.GetComponent<TextMeshProUGUI>().text = "The Cop thanks you for your time and sends you on your way";
            TextBoxCop1.GetComponent<TextMeshProUGUI>().text = "";
            TextBoxCop2.GetComponent<TextMeshProUGUI>().text = "";


            Choice1Cop.SetActive(false);
            Choice2Cop.SetActive(false);

            Debug.Log(option2 + "YAY");


            if (StartTimer == true)
            {
                option2 = false;
                SceneManager.LoadScene(2);
            }


        }

    }
   
    public void ChoiceOption2()
    {
        HasChosen = true;
       
        if (option2 == true)
        {
            
            GameManager.instance.Event1Checker = 2;
            TextBoxQuestionCop.GetComponent<TextMeshProUGUI>().text = "";
            TextBoxQuestionCop.GetComponent<TextMeshProUGUI>().text = "The argument gets heated and he takes you in";
            TextBoxCop1.GetComponent<TextMeshProUGUI>().text = "";
            TextBoxCop2.GetComponent<TextMeshProUGUI>().text = "";

            Choice1Cop.SetActive(false);
            Choice2Cop.SetActive(false);
            option1 = false;
            if (StartTimer == true)
            {
                Debug.Log("Goooooo");
             
                SceneManager.LoadScene(0);
                GameManager.instance.EventNumber = 0;


            }
          
        }

    }
    public void EventCountDown()
        {

            if (HasChosen == true)
            {
                EventTimer -= Time.deltaTime;
                Debug.Log(HasChosen);

                StartTimer = true;
                if (EventTimer <= 0)
                {
                    ChoiceOption1();
                    ChoiceOption2();
            }

            }
        }
        public void Update()
        {
            EventCountDown();
        }


}
