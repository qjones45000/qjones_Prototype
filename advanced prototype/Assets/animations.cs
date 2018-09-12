using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animations : MonoBehaviour {

    public Animator anim;
    public bool fight; 
    
    
	// Use this for initialization
	void Start () {

        anim = GetComponent<Animator>();
		
	}
	
	// Update is called once per frame
	void Update () {

        if (fight == true)
        {
            if (Input.GetKeyDown("j"))
            {
                anim.Play("fight");
            }

            if (Input.GetKeyDown("k"))
            {
                anim.Play("kick");
            }

            if (Input.GetKeyDown("h"))
            {
                anim.Play("LEFT ARM");
            }
            if (Input.GetKeyDown("l"))
            {
                anim.Play("power");
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.Keypad1))
            {
                anim.Play("fight");
            }

            if (Input.GetKeyDown(KeyCode.Keypad2))
            {
                anim.Play("kick");
            }

            if (Input.GetKeyDown(KeyCode.Keypad3))
            {
                anim.Play("LEFT ARM");
            }
            if (Input.GetKeyDown(KeyCode.Keypad5))
            {
                anim.Play("power");
            }


        }
     
	}
}
