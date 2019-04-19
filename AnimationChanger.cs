using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationChanger : MonoBehaviour {
    // Use this for initialization
    public int anim;
	void Start () {
        anim = GameManager.instance.EventNumber;
        if (anim <= 0)
        {
            this.gameObject.GetComponent<Animator>().SetInteger("Time", 0);
        }
       else  if (anim == 1 || anim >= 11)
        {
            this.gameObject.GetComponent<Animator>().SetInteger("Time", 1);
        }
        else if (anim >= 2 && anim < 11)
        {
            this.gameObject.GetComponent<Animator>().SetInteger("Time", 2);
        }
        this.gameObject.GetComponent<Animator>().SetBool("Doggo", GameManager.instance.Doggo);
        this.gameObject.GetComponent<Animator>().SetBool("Wolfo", GameManager.instance.Wolfo);
    

    }

    // Update is called once per frame
    void Update () {
		
	}
}
