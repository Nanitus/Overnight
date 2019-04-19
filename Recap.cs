using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
public class Recap : MonoBehaviour {

 /*   public GameObject RecapText;
    public GameObject RecapClick;
    float EventTimer = 5.0f;
    public bool optionOne = false;
    public bool HasChosen = false;
    public bool StartTimer = false;
    public bool Loops = false;
    public int counter = 0;


    // Use this for initialization
    void Start () {
        RecapText.GetComponent<TextMeshProUGUI>().text = "The Points in the journey";
        RecapClick.SetActive(false);
        Rekapa();
    }

    public void Rekapa()
    {
        if (GameManager.instance.Event1Checker == 1)
        {

            HasChosen = true;

            if( StartTimer == true)
            {
                RecapClick.SetActive(true);
                RecapText.GetComponent<TextMeshProUGUI>().text = "talked with cop";
                HasChosen = false;
                StartTimer = false;
                counter += counter;
                GameManager.instance.Event1Checker = 0;
                return;

            }

        }
        if(GameManager.instance.Event1Checker == 3)
        {
            HasChosen = true;
   
            if (StartTimer == true)
            {
                RecapClick.SetActive(true);
                RecapText.GetComponent<TextMeshProUGUI>().text = "dindt interact with cop";
                HasChosen = false;
                StartTimer = false;
                counter += counter;
                GameManager.instance.Event1Checker = 0;
                return;

            }

        }
        if(GameManager.instance.Event2Checker== 1)
        {

            HasChosen = true;

            if (StartTimer == true)
            {
                RecapClick.SetActive(true);
                RecapText.GetComponent<TextMeshProUGUI>().text = "get dog";
                HasChosen = false;
                StartTimer = false;
                counter += counter;
                GameManager.instance.Event2Checker = 0;
                return;
            }

        }
        if (GameManager.instance.Event2Checker == 2)
        {
            HasChosen = true;

            if (StartTimer == true)
            {
                RecapClick.SetActive(true);
                RecapText.GetComponent<TextMeshProUGUI>().text = "wolf bite";
                HasChosen = false;
                StartTimer = false;
                counter += counter;
                GameManager.instance.Event2Checker = 0;
                return;
            }

        }
        if (GameManager.instance.Event2Checker == 3)
        {
            HasChosen = true;

            if (StartTimer == true)
            {
                RecapClick.SetActive(true);
                RecapText.GetComponent<TextMeshProUGUI>().text = "nothing";
                HasChosen = false;
                StartTimer = false;
                counter += counter;
                GameManager.instance.Event2Checker = 0;
                return;

            }

        }
        if (GameManager.instance.Event3Checker == 1)
        {
            HasChosen = true;

            if (StartTimer == true)
            {
                RecapClick.SetActive(true);
                RecapText.GetComponent<TextMeshProUGUI>().text = "dog save you";
                HasChosen = false;
                StartTimer = false;
                counter += counter;
                GameManager.instance.Event3Checker = 0;
                return;
            }
 
        }
        if (GameManager.instance.Event3Checker == 2)
        {
            HasChosen = true;

            if (StartTimer == true)
            {
                RecapClick.SetActive(true);
                RecapText.GetComponent<TextMeshProUGUI>().text = "mugged";
                HasChosen = false;
                StartTimer = false;
                counter += counter;
                GameManager.instance.Event3Checker = 0;
                return;
            }

        }
        if (GameManager.instance.Event3Checker == 3)
        {
            HasChosen = true;

            if (StartTimer == true)
            {
                RecapClick.SetActive(true);
                RecapText.GetComponent<TextMeshProUGUI>().text = "nothing";
                HasChosen = false;
                StartTimer = false;
                counter += counter;
                GameManager.instance.Event3Checker = 0;
                return;
            }

        }
        if (GameManager.instance.Event4Checker == 1)
        {
            HasChosen = true;

            if (StartTimer == true)
            {
                RecapClick.SetActive(true);
                RecapText.GetComponent<TextMeshProUGUI>().text = "give dog";
                HasChosen = false;
                StartTimer = false;
                counter += counter;
                GameManager.instance.EndingNumber = 1;
                GameManager.instance.Event4Checker = 0;
                return;
            }

        }
        if (GameManager.instance.Event4Checker == 2)
        {
            HasChosen = true;

            if (StartTimer == true)
            {
                RecapClick.SetActive(true);
                RecapText.GetComponent<TextMeshProUGUI>().text = "mug her";
                HasChosen = false;
                StartTimer = false;
                counter += counter;
                GameManager.instance.EndingNumber = 2;
                GameManager.instance.Event4Checker = 0;
                return;
            }

        }
        if (GameManager.instance.Event4Checker == 3)
        {
            HasChosen = true;

            if (StartTimer == true)
            {
                RecapClick.SetActive(true);
                RecapText.GetComponent<TextMeshProUGUI>().text = "talk";
                HasChosen = false;
                StartTimer = false;
                counter += counter;
                GameManager.instance.EndingNumber = 3;
                GameManager.instance.Event4Checker = 0;
                return;
            }

        }

        if(GameManager.instance.Event1Checker == 0 && GameManager.instance.Event2Checker == 0 && GameManager.instance.Event3Checker == 0 && GameManager.instance.Event1Checker == 0)
        {
            if (GameManager.instance.EndingNumber >= 1)
            {
                SceneManager.LoadScene(8);
            }
            if (GameManager.instance.EndingNumber <= 1)
            {
                SceneManager.LoadScene(0);
            }
        }

    }

    public void SceneChange()
    {
        SceneManager.LoadScene(7);
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
                Rekapa();
            }

        }
    }
    public void Update()
    {
        EventCountDown();
    }*/
}
