using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour {

	public float currenthealth {get; set;}
	public float Max_health {get; set;} 

	public Slider healthbar;



	void start ()
	{
		Max_health = 20f;

		currenthealth = Max_health;

		healthbar.value = calc_health ();
	}

		void update()
		{
		if (Input.GetKeyDown (KeyCode.X)) 
		{
			dealDamage (6);
		}



		}
	float calc_health()
	{
		return currenthealth / Max_health;
	}
	
	


	void dealDamage (float damage)
	{
		currenthealth -= damage;

		if (currenthealth <= 0) 
		
		Die ();
		
	}

		void Die ()
		{
			currenthealth = 0;
			Debug.Log("you died");
		}


}
