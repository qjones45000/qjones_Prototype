using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleScript : MonoBehaviour {

    public ParticleSystem Powerlauncher;
    public ParticleSystem emissionTho;
	// Use this for initialization
	void Start () {
		
	}

     void OnParticleCollision(GameObject other)
    {
        EmitAtLocation(); 
    }

    void EmitAtLocation()
    {
        emissionTho.Emit(1);
    }

    // Update is called once per frame
    void Update () {

        if (Input.GetButton("Fire1"))
        {
            Powerlauncher.Emit(1);
        }


		
	}
}
