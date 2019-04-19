using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;



public class AnimationCountdown : MonoBehaviour {

    float AnimationTimer = 15.0f;


    //start timer for cutscene

    void Start () {
    
    }

    public void Update()
    {
        TravelTimer();
    }

    public void TravelTimer()
    {
                AnimationTimer -= Time.deltaTime;
        
        if (AnimationTimer < 0)
        {

            SceneManager.LoadScene(2);
            Debug.Log("test1");


        }
        //skip cutscene
        else if (Input.GetButtonDown("SkipCutscene"))
        {
            SceneManager.LoadScene(2);
            Debug.Log("test");


        }
        

    }
}
