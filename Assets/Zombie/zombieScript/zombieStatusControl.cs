using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class zombieStatusControl : MonoBehaviour {

    public int health = 100;

    [Header("Unity Stuff")]
    public Image healthBar;


    void Start ()
    {

	}

    void Update()
    {
        healthBar.fillAmount = health / 100f;
    }
}
