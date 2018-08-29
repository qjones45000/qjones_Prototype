using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {

	public static float Max_Health = 100f; 

	public  float health = Max_Health; 

	public move oponent; 

    public float speed;

    private Rigidbody rb;

    public bool PlayerOne;

    float moveHorizontal;
    float moveVertical;

	public float healthpercent {
		get { 
			return health / Max_Health; 
		}
	}

	public Rigidbody rigid {
		get { 
			return this.rb;
		}
	}

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
		  

    void FixedUpdate()
    {
        if (PlayerOne == true)
        {
            moveHorizontal = Input.GetAxis("Horizontal p1");
            moveVertical = Input.GetAxis("Vertical p1");
        }
        else
        {
            moveHorizontal = Input.GetAxis("Horizontal p2");
            moveVertical = Input.GetAxis("Vertical p2");
        }

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);


    }
}