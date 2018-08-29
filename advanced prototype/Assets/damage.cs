using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damage : MonoBehaviour {

	public float injured = 5f;


	
	void OnTriggerEnter(Collider other)
	{
		 
		other.gameObject.GetComponent<PlayerHealth>().TakeDamage(injured);  
	}
}
