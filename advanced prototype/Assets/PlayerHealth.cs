using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {

	public Image healthbar; 
	public float Max_Health = 100f; 
	public float currenthealth = 0f; 
	public bool alive = true; 


	void start ()
	{
		alive = true; 
		currenthealth = Max_Health;
		sethealthbar (); 
	
	}

	void DoDamage()
	{
		TakeDamage (10f); 

	}

	public void TakeDamage (float amount)
	{
		if (!alive) 
		{
			return; 
		}

		if (currenthealth <= 0) 
		{
			currenthealth = 0;
			alive = false; 
			gameObject.SetActive (false); 
		}
		currenthealth -= amount;
		sethealthbar (); 
	}

	public void sethealthbar()
	{
		float my_health = currenthealth / Max_Health;
		healthbar.transform.localScale = new Vector3 (Mathf.Clamp (my_health, 0f, 1f), healthbar.transform.localScale.y, healthbar.transform.localScale.z);
	}

}
