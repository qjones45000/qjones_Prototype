using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player2Health : MonoBehaviour {

    public float currenthealth = 0;
    public float Max_health = 100f;




    public Slider healthbar;



    void Start()
    {
        currenthealth = Max_health;
    }




    float calc_health()
    {
        return currenthealth / Max_health;
    }




    public void dealDamage(float damage)
    {
        currenthealth -= damage;

        if (currenthealth <= 0)

            Die();

    }

    void Die()
    {
        currenthealth = 0;
        Debug.Log("player 2 died");
    }

    void OnCollisionEnter(Collision collision)
    {


        if (collision.gameObject.tag == "fist")
        {
            dealDamage(6);
            Debug.Log("you got fucked");
            calc_health();


        }

        healthbar.value = currenthealth;
    }

}
