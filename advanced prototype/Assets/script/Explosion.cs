using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour {

    public Transform blast;

	// Use this for initialization
	void Start () {

        blast.GetComponent<ParticleSystem>().enableEmission = false; 
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
    {
        blast.GetComponent<ParticleSystem>().enableEmission = true;
       
    }
}
