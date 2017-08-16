using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class zombieStatusControl : MonoBehaviour {

    public static int health = 100;
    public int damage = 50;
    public float reduceRate = 3.0f;
    public float nextReduce = 3.0f; //start of health reduce time 
    public float deathTime = 0.0f;
    public GameObject obj;

    public Image healthBar;

    void Start ()
    {
        
	}

    void Update()
    {
        if (Time.time > nextReduce)
        {
            //reduceHealth();
            nextReduce = Time.time + reduceRate;
            if (health <= 0 && deathTime == 0)
            {
                deathTime = Time.time + 3.0f;
            }
        }
        if (Time.time > deathTime && deathTime != 0)
        {
            obj.SetActive(false);
        }
    }

    public void reduceHealth() //function for reduce health when the zombie is being attacked.
    {
        health -= damage;
        healthBar.fillAmount = health / 100f;
    }
}
