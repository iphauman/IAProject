using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunMovementController : MonoBehaviour {

    public static int bullet = 8;
    public static int damage;
    public static bool focusStatus = false;
    static Animator anim;
    public GameObject obj;  //get the focused object
	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
        
	}
	
	// Update is called once per frame
	void Update () {
        obj = GameObject.FindWithTag("zombie");
		if(obj.GetComponent<ViewTrigger>().Focused == true && bullet != 0)
        {
            anim.SetBool("isShooting", true);
        }
        else
        {
            anim.SetBool("isShooting", false);
        }

        if(bullet <= 0)
        {
            anim.SetBool("isReloading", true);
            anim.SetBool("isShooting", false);
        }
	}
}
