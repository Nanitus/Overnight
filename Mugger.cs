using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Mugger : MonoBehaviour {



    public GameObject TextMugger;
    public GameObject MuggerInter;
    public GameObject MuggerQuestion;
    float EventTimer = 5.0f;
    public bool optionOne = false;
    public bool HasChosen = false;
    public bool StartTimer = false;

    void Start () {
        MuggerOptionOther();
        MuggerEncounter();

	}

   public void MuggerEncounter()
    {
        MuggerQuestion.GetComponent<TextMeshProUGUI>().text = "A man comes at you with a knife asking for your money";
        TextMugger.GetComponent<TextMeshProUGUI>().text = "Fight the masked man";

    }

    public void MuggerOption()
    {
        if (GameManager.instance.Doggo == true)
        {
            GameManager.instance.Event3Checker =  1;
            GameManager.instance.moral = GameManager.instance.moral + 7;
            HasChosen = true;
            MuggerQuestion.GetComponent<TextMeshProUGUI>().text = "The dog you saved earlier jumps at the mugger and scares him away";
            TextMugger.SetActive(false);
            MuggerInter.SetActive(false);
            if (StartTimer == true)
            {

                GameManager.instance.EventNumber = GameManager.instance.EventNumber + 1;
                SceneManager.LoadScene(6);
            }

        }
        if (GameManager.instance.Wolfo == true)
        {
            GameManager.instance.Event3Checker = 2;
            GameManager.instance.moral = GameManager.instance.moral - 7;
            HasChosen = true;
            MuggerQuestion.GetComponent<TextMeshProUGUI>().text = "Becasue of the injury on your hand you can not fight back and the man takes your money";
            TextMugger.SetActive(false);
            MuggerInter.SetActive(false);

            if (StartTimer == true)
            {

                GameManager.instance.EventNumber = GameManager.instance.EventNumber + 1;
                SceneManager.LoadScene(6);
            }
        }


    }
    public void MuggerOptionOther()
    {
        if (GameManager.instance.Doggo == false && GameManager.instance.Wolfo == false)
        {
            GameManager.instance.Event3Checker = 3;
            GameManager.instance.EventNumber = GameManager.instance.EventNumber + 1;
            SceneManager.LoadScene(6);
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
                MuggerOption();
            }

        }
    }
    public void Update()
    {
        EventCountDown();
    }



}
