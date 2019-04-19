using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int ChoiceMade = 0;
    public int EventNumber = 0;
    public int moral = 0;
    public bool Doggo = false;
    public bool Wolfo = false;
    public int EndingNumber = 0;
    public int Event1Checker = 0;
    public int Event2Checker = 0;
    public int Event3Checker = 0;
    public int Event4Checker = 0;
    
    // Use this for initialization
    void Awake()
    {
        //check if instance exists alrady
        if (instance == null)
        {
            //if not, set instance to this
            instance = this;
        }
        //if it exists, but not this one
        else if (instance != this)
        {
            //destroy
            Destroy(gameObject);
        }
        //set this to be not destroyable
        DontDestroyOnLoad(gameObject);


    }
}
