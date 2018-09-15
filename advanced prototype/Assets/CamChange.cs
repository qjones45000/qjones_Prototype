using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamChange : MonoBehaviour {

    public Camera camleft;
    public Camera camright;
    

	// Use this for initialization
	void Start () {

        camleft.enabled = false;
        camright.enabled = true;
		
	}
	
	// Update is called once per frame
	void Update () {
           
		
	}

    private void OnTriggerEnter(Collider other)
    {
      if(other.gameObject.tag == "camswitch")
        {

            camleft.enabled = true;
            camright.enabled = false;
        }
    }
}
