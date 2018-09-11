using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour {

    public float currenthealth = 0;
    public float Max_health = 100f;
    public bool playerHealth;

    public float Player2Health = 0;
    public float Player2MaxHP = 100f;
    


	public Slider healthbar;
    public Slider player2health;



	void Start ()
	{
		currenthealth = Max_health;

        Player2Health = Player2MaxHP;
	}




    float calc_health()
	{
		return currenthealth / Max_health;
	}

    float Calc_Health2()
    {
        return Player2Health / Player2MaxHP;
    }
	



	public void dealDamage (float damage)
	{
        

		currenthealth -= damage;

		if (currenthealth <= 0) 
		
		Die ();

        
		
	}

    public void DealDamage2 (float Damage2)
    {
        Player2Health -= Damage2;

        if (Player2Health <= 0)

            Die();
    }

		void Die ()
		{
			currenthealth = 0;
        Player2Health = 0;
			Debug.Log("you died");
		}

    void OnCollisionEnter(Collision collision)
    {
        if (playerHealth == true)
        {
            if (collision.gameObject.tag == "Hand")
            {
                dealDamage(6);
                Debug.Log("you have been hit");
                calc_health();
            }

            healthbar.value = currenthealth;
        }

        else
        {
            if (collision.gameObject.tag == "fist")
            {
                DealDamage2(6);
                Debug.Log("you got fucked");
                Calc_Health2();
            }

            player2health.value = Player2Health;

        }
        }
    }
        
    


