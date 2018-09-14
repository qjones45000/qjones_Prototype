using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour {

	[SerializeField] private Transform dude;
	[SerializeField] private Transform spawnpoint;
	 

   

    void OnTriggerEnter(Collider other)
    {

   
       

           dude.transform.position = spawnpoint.transform.position;
            Debug.Log("collided");
        
        
    }

}
