using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {

    public int StartingHealth = 100;
    public int CurrentHealth;
    public Slider HealthSlider; 


	// Use this for initialization
	void Start () {

        CurrentHealth = StartingHealth; 
		 
	}
	
	// Update is called once per frame
	void Update () {
        
	}

  public void TakeDamage(int amount)
    {
        CurrentHealth -= amount;
        HealthSlider.value = CurrentHealth;
    }
}
