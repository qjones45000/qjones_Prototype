using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fist : MonoBehaviour {
	public  string punchname;
	public float damage; 
	public move owner; 

	void OnTriggerEnter(Collider other)
	{
		move somebody = other.gameObject.GetComponent<move> ();

		if (somebody != null && somebody != owner) 
		{
			Debug.Log("i hit" + somebody + "with" + punchname); 
		}
			
	}
}