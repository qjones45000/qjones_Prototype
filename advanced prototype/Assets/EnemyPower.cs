using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPower : MonoBehaviour {

    public Rigidbody enemyPower;
    public Transform EnemyForm;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Keypad5))


        {
            Rigidbody Emove;

            Emove = Instantiate(enemyPower, EnemyForm.position, EnemyForm.rotation) as Rigidbody;
            Emove.AddForce(EnemyForm.forward * 5000);


        }

    }
}
