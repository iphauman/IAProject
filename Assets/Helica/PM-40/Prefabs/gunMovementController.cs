using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunMovementController : MonoBehaviour {

    [Header("Gun Property")]
    public int bullet = 3;
    public int damage = 10;

    public static bool focusStatus = false;
    static Animator anim;

    [Header("Focused Object")]
    public GameObject obj;  //get the focused object

    [Header("Gun fire")]
    public AudioSource audio1;
    public float fireRate = 1F;
    private float nextFire = 0.0F;
    [Header("Gun reload")]
    public AudioSource audio2;
    public float reloadRate = 1f;
    private float reload;

    void Start() {
        anim = GetComponent<Animator>();
        reload = 0;
    }

    // Update is called once per frame
    void Update() {

        obj = GameObject.FindWithTag("zombie");

        if (obj.GetComponent<ViewTrigger>().Focused == true && bullet != 0 && Time.time > nextFire)
        {
            anim.SetBool("isShooting", true);
            audio1.Play();
            bullet--;
            GameObject.FindWithTag("zombie").GetComponent<zombieStatusControl>().health -= damage;
            nextFire = Time.time + fireRate;
        }
        else
        {
            anim.SetBool("isShooting", false);
        }

        if (bullet == 0)
        {
            audio2.Play();
            reload += Time.deltaTime;
            anim.SetBool("isShooting", false);
            anim.SetTrigger("isReloading");
            if (reload > reloadRate)
            {
                reload = 0;
                bullet = 3;
            }
            
        }
        else
        {
            anim.SetBool("isShooting", false);
        }
        



    }


}
