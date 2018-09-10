using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player2Health : MonoBehaviour {

    public float currentHealth = 0;
    public float max_health = 100f;




    public Slider dudehealth;



    void Start()
    {
        currentHealth = max_health;
    }




    float Calc_Health()
    {
        return currentHealth / max_health;
    }




    public void feelDamage(float damage)
    {
        currentHealth -= damage;

        if (currentHealth <= 0)

            Die();

    }

    void Die()
    {
        currentHealth = 0;
        Debug.Log("player 2 died");
    }

    void OnCollisionEnter(Collision collision)
    {


        if (collision.gameObject.tag == "fist")
        {
            feelDamage(6);
            Debug.Log("you got fucked");
            Calc_Health();


        }

        dudehealth.value = currentHealth;
    }

}
