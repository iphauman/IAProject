using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthBarController : MonoBehaviour {
    public static Image healthBar;

    void Start () {
        healthBar = GetComponent<Image>();
	}
	
	void Update () {
        
        healthBar.fillAmount = zombieStatusControl.health / 100f;
    }
}
