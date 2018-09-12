using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectile : MonoBehaviour {

    public Rigidbody power;
    public Transform powerform;

    public bool powers;

    public Rigidbody enemyPower;
    public Transform EnemyForm;

	// Use this for initialization
	void Start () {
       

    }
	
	// Update is called once per frame
	void Update () {
        if (powers == true)
        {
            if (Input.GetKeyDown("l"))
            {
                Rigidbody Pmove;

                Pmove = Instantiate(power, powerform.position, powerform.rotation) as Rigidbody;
                Pmove.AddForce(powerform.forward * 5000);


            }
            else
            {
                if (Input.GetKeyDown(KeyCode.Keypad5))
                

                    {
                        Rigidbody Emove;

                        Emove = Instantiate(enemyPower, EnemyForm.position, EnemyForm.rotation) as Rigidbody;
                        Emove.AddForce(EnemyForm.forward * 5000);


                    }
                }
        }

   

		
	}
}
