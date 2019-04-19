using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Tanya : MonoBehaviour
{
    public GameObject TextTanya;
    public GameObject TextBoxAction;
    public GameObject ActionBox;
    float EventTimer = 5.0f;
    public bool optionOne = false;
    public bool HasChosen = false;
    public bool StartTimer = false;

    private void Start()
    {
        //NeutralBoyCheck();
        TanyaStart();
    }

    public void TanyaStart()
    {
        TextTanya.GetComponent<TextMeshProUGUI>().text = "You see a young girl walking around late in the night, what do you do ";
        TextBoxAction.GetComponent<TextMeshProUGUI>().text = "Continue";
    }
   
    public void GoodBoyCheck()
    {
        if (GameManager.instance.Doggo == true && GameManager.instance.moral >= 1)
        {
           // GameManager.instance.Event4Checker = 1;
            GameManager.instance.EndingNumber = 1;
            HasChosen = true;
            TextTanya.GetComponent<TextMeshProUGUI>().text = "You find out that she is an orphan and your dog seems to cheer her up, you let him go with her";
            TextBoxAction.SetActive(false);
            ActionBox.SetActive(false);
            if (StartTimer == true)
            {
                GameManager.instance.Doggo = true;
                GameManager.instance.EventNumber = GameManager.instance.EventNumber + 1;

                SceneManager.LoadScene(0);
            }

        }
        if (GameManager.instance.Doggo == true && GameManager.instance.moral <= 0)
        {
            //  GameManager.instance.Event4Checker = 2;
            GameManager.instance.EndingNumber = 2;
            HasChosen = true;
            TextTanya.GetComponent<TextMeshProUGUI>().text = "You find out that she is an orphan and has nowhere to go, you decide to take her with you";
            TextBoxAction.SetActive(false);
            ActionBox.SetActive(false);
            if (StartTimer == true)
            {
                GameManager.instance.Doggo = true;
                GameManager.instance.EventNumber = GameManager.instance.EventNumber + 1;

                SceneManager.LoadScene(0);
            }
        }
        if (GameManager.instance.Doggo == false && GameManager.instance.Wolfo == false)
        {
            // GameManager.instance.Event4Checker = 2;
            GameManager.instance.EndingNumber = 2;
            HasChosen = true;
            TextTanya.GetComponent<TextMeshProUGUI>().text = "You find out that she is an orphan and has nowhere to go, you decide to take her with you";
            TextBoxAction.SetActive(false);
            ActionBox.SetActive(false);
            if (StartTimer == true)
            {
                GameManager.instance.Doggo = true;
                GameManager.instance.EventNumber = GameManager.instance.EventNumber + 1;

                SceneManager.LoadScene(0);
            }
        }
        if (GameManager.instance.Wolfo == true && GameManager.instance.moral >= 0)
        {
            //  GameManager.instance.Event1Checker = 2;
            GameManager.instance.EndingNumber = 2;
            HasChosen = true;
            TextTanya.GetComponent<TextMeshProUGUI>().text = "You find out that she is an orphan and has nowhere to go, you decide to take her with you";
            TextBoxAction.SetActive(false);
            ActionBox.SetActive(false);
            if (StartTimer == true)
            {
                GameManager.instance.Doggo = true;
                GameManager.instance.EventNumber = GameManager.instance.EventNumber + 1;

                SceneManager.LoadScene(0);
            }
        }
    
     
        if (GameManager.instance.Wolfo == true && GameManager.instance.moral <= -1)
        {
            // GameManager.instance.Event1Checker = 3;
            GameManager.instance.EndingNumber = 3;
            GameManager.instance.moral = GameManager.instance.moral - 2;
            HasChosen = true;
            TextTanya.GetComponent<TextMeshProUGUI>().text = "You realize that she is all alone and has a small pouch that seems to be valueable, you decide to take it from her by force";
            TextBoxAction.SetActive(false);
            ActionBox.SetActive(false);
            if (StartTimer == true)
            {
                GameManager.instance.Doggo = true;
                GameManager.instance.EventNumber = GameManager.instance.EventNumber + 1;

                SceneManager.LoadScene(0);
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
                GoodBoyCheck();
            }

        }
    }
    public void Update()
    {
        EventCountDown();
    }


}
