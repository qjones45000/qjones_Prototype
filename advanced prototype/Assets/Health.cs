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

     void OnCollisionEnter(Collision collision)
    {
        
        
            if (collision.gameObject.tag == "Hand")
            {
                dealDamage(6);
                Debug.Log("you have been hit");
                calc_health();


            }
                
            healthbar.value = currenthealth;
        }
        
    }


