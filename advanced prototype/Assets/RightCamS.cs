using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightCamS : MonoBehaviour {

    public Camera camleft;
    public Camera camright;


    // Use this for initialization
    void Start()
    {

    

    }

    // Update is called once per frame
    void Update()
    {


    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "camswitch")
        {
            camleft.enabled = false;
            camright.enabled = true;

        }
    }
}
