using System.Collections;
using UnityEngine;


public class Health : MonoBehaviour {

    public float Max_Health = 100f;
    public float Currenthealth = 0f;
    public GameObject HealthBar;


    void start()
    {
        Currenthealth = Max_Health;
        InvokeRepeating("decreaseHealth", 1f, 1f);
    }

     void Update()
    {
        

    }

    void decreaseHealth()
    {
        Currenthealth -= 2f;
        float calc_Health = Currenthealth / Max_Health;
        SetHealhBar(calc_Health);
    }

    public void SetHealhBar(float myHealth)
    {
        HealthBar.transform.localScale = new Vector3 (Mathf.Clamp(myHealth, 0f, 1f),
                                               HealthBar.transform.localScale.y,
                                               HealthBar.transform.localScale.x);
    }
}
