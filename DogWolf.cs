using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class DogWolf : MonoBehaviour {

    public GameObject TextBoxDogTalk;
    public GameObject TextBoxDogInvest;
    public GameObject DogAction1;
    float EventTimer = 5.0f;
    public bool optionOne = false;
    public bool HasChosen = false;
    public bool StartTimer = false;



    // Use this for initialization
    void Start () {
        DogOptionOther();

        DogWolfEncounter();

    }

    public void DogWolfEncounter()
    {
        Debug.Log("ok");
        TextBoxDogTalk.GetComponent<TextMeshProUGUI>().text = "You stop for a bathroom break and you hear a sound from the bush, what do you do?";
        TextBoxDogInvest.GetComponent<TextMeshProUGUI>().text = "Investigate";
        
        
    }
    public void DogOption()
    {
        if (GameManager.instance.moral >= 6)
        {
            GameManager.instance.Event2Checker = 1;
            HasChosen = true;
            Debug.Log(GameManager.instance.moral + " hello");
            TextBoxDogInvest.SetActive(false);
            DogAction1.SetActive(false);
            TextBoxDogTalk.GetComponent<TextMeshProUGUI>().text = "You find a small stray Jack russell in the bush, he seems friendly so you take him with you";
            if (StartTimer == true)
            {
                GameManager.instance.Doggo = true;
                GameManager.instance.EventNumber = GameManager.instance.EventNumber + 1;

                SceneManager.LoadScene(2);
            }



        }
        if (GameManager.instance.moral <= -6)
        {
            GameManager.instance.Event2Checker = 2; 
            HasChosen = true;
            Debug.Log(GameManager.instance.moral + " hey");
            TextBoxDogInvest.SetActive(false);
            DogAction1.SetActive(false);
            TextBoxDogTalk.GetComponent<TextMeshProUGUI>().text = "You find a wolf that stares at you aggressively, he attacks you and severely injures your hand";

            if (StartTimer == true)
            {
                GameManager.instance.Wolfo = true;
                GameManager.instance.EventNumber = GameManager.instance.EventNumber + 1;
                SceneManager.LoadScene(2);
            }
            else
            {
                return;
            }

        }
    }

    public void DogOptionOther()
        {

        if (GameManager.instance.moral >= -5 && GameManager.instance.moral <= 5) 
        {
            GameManager.instance.Event2Checker = 3;
            Debug.Log(GameManager.instance.moral + " hi");


            GameManager.instance.EventNumber = GameManager.instance.EventNumber + 1;

  
            SceneManager.LoadScene(2);

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
                DogOption();
            }

        }
    }
    public void Update()
    {
        EventCountDown();
    }


}

