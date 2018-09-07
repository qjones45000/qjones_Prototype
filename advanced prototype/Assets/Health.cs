using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour {

    public float currenthealth = 0;
    public float Max_health = 100f;


	public Slider healthbar;



	void Start ()
	{
		currenthealth = Max_health;
	}

	void Update()
	{
	    if (Input.GetKeyDown ("p"))
	    {
		    dealDamage (6);
	    }

        healthbar.value = currenthealth;
    }


    float calc_health()
	{
		return currenthealth / Max_health;
	}
	
	


	public void dealDamage (float damage)
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
