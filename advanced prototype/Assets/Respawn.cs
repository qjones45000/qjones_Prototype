using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour {

    public GameObject Player;
    public Transform spawnpoint;
   

   

    void OnTriggerEnter(Collider other)
    {

   
       

           Player.transform.position = spawnpoint.transform.position;
            Debug.Log("collided");
        
        
    }

}
