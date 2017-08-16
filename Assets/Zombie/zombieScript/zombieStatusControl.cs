using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class zombieStatusControl : MonoBehaviour {

    public int healthAttr = 100;
    public static int health = 100;
    
    public GameObject obj;

    

    void Start ()
    {
        
	}

    void Update()
    {
        health = healthAttr;
    }

    
}
