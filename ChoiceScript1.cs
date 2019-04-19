using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;



public class ChoiceScript1 : MonoBehaviour {
    public GameObject TextBox1;
    public GameObject TextBox2;
    public GameObject TextBox3;
    public GameObject TextBox4;
    public GameObject TextBox5;
    public GameObject TextBoxQuestion;
    public GameObject Choice1;
    public GameObject Choice2;
    public GameObject Choice3;
    public GameObject Choice4;
    public GameObject Choice5;

    public void Start()
    {

        QuestionBox();
        
    }

    public void QuestionBox()
    {
        if (GameManager.instance.EventNumber == 0)
        {

            TextBoxQuestion.GetComponent<TextMeshProUGUI>().text = "A deer jumps in front of your car out of nowhere, what do you do?";
            TextBox1.GetComponent<TextMeshProUGUI>().text = "Hit the brakes";
            TextBox2.GetComponent<TextMeshProUGUI>().text = "Swerve out of the way";
            TextBox3.GetComponent<TextMeshProUGUI>().text = "Slow Down and let the deer pass";
            TextBox4.GetComponent<TextMeshProUGUI>().text = "Continue with your path";
            TextBox5.GetComponent<TextMeshProUGUI>().text = "Speed Up and run through";

        }
        else if (GameManager.instance.EventNumber == 1)
        {
   
            TextBoxQuestion.GetComponent<TextMeshProUGUI>().text = "Off in the distance there is a car that seems to be broken down, what do you do?";
            TextBox1.GetComponent<TextMeshProUGUI>().text = "Help start their car back up";
            TextBox2.GetComponent<TextMeshProUGUI>().text = "Call someone to help them";
            TextBox3.GetComponent<TextMeshProUGUI>().text = "Drive by and ignore them";
            TextBox4.GetComponent<TextMeshProUGUI>().text = "Honk and laugh at them";
            TextBox5.GetComponent<TextMeshProUGUI>().text = "Throw a bottle at them";

        }
        else if (GameManager.instance.EventNumber == 2)
        {
            TextBoxQuestion.GetComponent<TextMeshProUGUI>().text = "You see a hitchhiker looking for a ride back home, what do you do?";
            TextBox1.GetComponent<TextMeshProUGUI>().text = "Take them to the next gas station";
            TextBox2.GetComponent<TextMeshProUGUI>().text = "Call a taxi to help them";
            TextBox3.GetComponent<TextMeshProUGUI>().text = "Drive by and ignore them";
            TextBox4.GetComponent<TextMeshProUGUI>().text = "Throw a bottle at them";
            TextBox5.GetComponent<TextMeshProUGUI>().text = "Hit person with your car";

        }
        else if (GameManager.instance.EventNumber == 3)
        {
            SceneManager.LoadScene(3);
        }

        else if (GameManager.instance.EventNumber == 4)
        {
            TextBoxQuestion.GetComponent<TextMeshProUGUI>().text = "You find a gas station with a homeless man sitting nearby, what do you do?";
            TextBox1.GetComponent<TextMeshProUGUI>().text = "Pay for gas and give the man food";
            TextBox2.GetComponent<TextMeshProUGUI>().text = "Pay for gas and give the change to the man";
            TextBox3.GetComponent<TextMeshProUGUI>().text = "Pay for gas";
            TextBox4.GetComponent<TextMeshProUGUI>().text = "Kick the homeless";
            TextBox5.GetComponent<TextMeshProUGUI>().text = "Kick homeless and drive away without paying for gas";
        }
        else if (GameManager.instance.EventNumber == 5)
        {
            TextBoxQuestion.GetComponent<TextMeshProUGUI>().text = "A man challenges you to a street race, what do you do?";
            TextBox1.GetComponent<TextMeshProUGUI>().text = "Call the police";
            TextBox2.GetComponent<TextMeshProUGUI>().text = "Ignore the racer";
            TextBox3.GetComponent<TextMeshProUGUI>().text = "Pretend to race and let him go";
            TextBox4.GetComponent<TextMeshProUGUI>().text = "Race the racer";
            TextBox5.GetComponent<TextMeshProUGUI>().text = "Force the racer to crash his car";
        }
        else if (GameManager.instance.EventNumber == 6)
        {
            SceneManager.LoadScene(4);

        }
        else if (GameManager.instance.EventNumber == 7)
        {
            GameManager.instance.moral = 0;
            TextBoxQuestion.GetComponent<TextMeshProUGUI>().text = "A biker gang surrounds you, what do you do?";
            TextBox1.GetComponent<TextMeshProUGUI>().text = "Call the police";
            TextBox2.GetComponent<TextMeshProUGUI>().text = "Talk to them and get them out of the way";
            TextBox3.GetComponent<TextMeshProUGUI>().text = "Drive away";
            TextBox4.GetComponent<TextMeshProUGUI>().text = "Ram through them";
            TextBox5.GetComponent<TextMeshProUGUI>().text = "Run all of them off the road";

        }
        else if (GameManager.instance.EventNumber == 8)
        {
            TextBoxQuestion.GetComponent<TextMeshProUGUI>().text = "You find a woman on the road in the rain, what do you do?";
            TextBox1.GetComponent<TextMeshProUGUI>().text = "Let her into the car";
            TextBox2.GetComponent<TextMeshProUGUI>().text = "Give her your spare umbrella";
            TextBox3.GetComponent<TextMeshProUGUI>().text = "Ignore";
            TextBox4.GetComponent<TextMeshProUGUI>().text = "Splash the woman with water";
            TextBox5.GetComponent<TextMeshProUGUI>().text = "Run over her";
        }
        else if (GameManager.instance.EventNumber == 9)
        {
            TextBoxQuestion.GetComponent<TextMeshProUGUI>().text = "You stop at a 24 hour diner, what do you do?";
            TextBox1.GetComponent<TextMeshProUGUI>().text = "Pay for someone else's meal";
            TextBox2.GetComponent<TextMeshProUGUI>().text = "Tip the waitress and leave";
            TextBox3.GetComponent<TextMeshProUGUI>().text = "Pay for food";
            TextBox4.GetComponent<TextMeshProUGUI>().text = "Dine and Dash";
            TextBox5.GetComponent<TextMeshProUGUI>().text = "Pick a fight with the man sitting near you";
        }

        else if (GameManager.instance.EventNumber == 10)
        {
            SceneManager.LoadScene(5);
        }
    }



    public void ChoiceOption1()
    {
        GameManager.instance.moral = GameManager.instance.moral + 2;
        TextBoxQuestion.GetComponent<TextMeshProUGUI>().text = "";
        TextBox1.GetComponent<TextMeshProUGUI>().text = "";
        TextBox2.GetComponent<TextMeshProUGUI>().text = "";
        TextBox3.GetComponent<TextMeshProUGUI>().text = "";
        TextBox4.GetComponent<TextMeshProUGUI>().text = "";
        TextBox5.GetComponent<TextMeshProUGUI>().text = "";
        GameManager.instance.ChoiceMade = GameManager.instance.ChoiceMade + 2;
        Debug.Log(GameManager.instance.moral);
        Debug.Log(GameManager.instance.EventNumber);
        GameManager.instance.EventNumber = GameManager.instance.EventNumber + 1;

        SceneManager.LoadScene(1);
    
    }

    public void ChoiceOption2()
    {
        GameManager.instance.moral = GameManager.instance.moral + 1;
        TextBoxQuestion.GetComponent<TextMeshProUGUI>().text = "";
        TextBox1.GetComponent<TextMeshProUGUI>().text = "";
        TextBox2.GetComponent<TextMeshProUGUI>().text = "";
        TextBox3.GetComponent<TextMeshProUGUI>().text = "";
        TextBox4.GetComponent<TextMeshProUGUI>().text = "";
        TextBox5.GetComponent<TextMeshProUGUI>().text = "";
        GameManager.instance.ChoiceMade = GameManager.instance.ChoiceMade + 1;
        Debug.Log(GameManager.instance.moral);
        Debug.Log(GameManager.instance.EventNumber);
        GameManager.instance.EventNumber = GameManager.instance.EventNumber + 1;
        SceneManager.LoadScene(1);


    }
    public void ChoiceOption3()
    {
         
        TextBoxQuestion.GetComponent<TextMeshProUGUI>().text = "";
        TextBox1.GetComponent<TextMeshProUGUI>().text = "";
        TextBox2.GetComponent<TextMeshProUGUI>().text = "";
        TextBox3.GetComponent<TextMeshProUGUI>().text = "";
        TextBox4.GetComponent<TextMeshProUGUI>().text = "";
        TextBox5.GetComponent<TextMeshProUGUI>().text = "";
        Debug.Log(GameManager.instance.moral);
        Debug.Log(GameManager.instance.EventNumber);
        GameManager.instance.EventNumber = GameManager.instance.EventNumber + 1;
        SceneManager.LoadScene(1);


    }
    public void ChoiceOption4()
    {
        GameManager.instance.moral = GameManager.instance.moral - 1;
        TextBoxQuestion.GetComponent<TextMeshProUGUI>().text = "";
        TextBox1.GetComponent<TextMeshProUGUI>().text = "";
        TextBox2.GetComponent<TextMeshProUGUI>().text = "";
        TextBox3.GetComponent<TextMeshProUGUI>().text = "";
        TextBox4.GetComponent<TextMeshProUGUI>().text = "";
        TextBox5.GetComponent<TextMeshProUGUI>().text = "";
        GameManager.instance.ChoiceMade = GameManager.instance.ChoiceMade - 1;
        Debug.Log(GameManager.instance.moral);
        Debug.Log(GameManager.instance.EventNumber);
        GameManager.instance.EventNumber = GameManager.instance.EventNumber + 1;
        SceneManager.LoadScene(1);


    }
    public void ChoiceOption5()
    {
        GameManager.instance.moral = GameManager.instance.moral - 2;
        TextBoxQuestion.GetComponent<TextMeshProUGUI>().text = "";
        TextBox1.GetComponent<TextMeshProUGUI>().text = "";
        TextBox2.GetComponent<TextMeshProUGUI>().text = "";
        TextBox3.GetComponent<TextMeshProUGUI>().text = "";
        TextBox4.GetComponent<TextMeshProUGUI>().text = "";
        TextBox5.GetComponent<TextMeshProUGUI>().text = "";
        GameManager.instance.ChoiceMade = GameManager.instance.ChoiceMade - 2;
        Debug.Log(GameManager.instance.moral);
        Debug.Log(GameManager.instance.EventNumber);
        GameManager.instance.EventNumber = GameManager.instance.EventNumber + 1;
        SceneManager.LoadScene(1);


    }



}
