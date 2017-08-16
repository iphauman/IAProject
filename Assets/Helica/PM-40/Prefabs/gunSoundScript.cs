using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gunSoundScript : MonoBehaviour {

    public AudioSource audio1;
    public AudioSource audio2;
    public GameObject obj;

    bool reload;
    bool fire;

    public float delayLength = 0.7f;
    float delay = 0;

    void Start () {

    }
    
    void Update()
    {
        obj = GetComponent<gunMovementController>().obj;
        reload = GetComponent<Animator>().GetBool("isReloading");
        fire = GetComponent<Animator>().GetBool("isShooting");
        
        if (fire == true)
        {
            if (delay == 0)
            {
                audio2.Play();
                gunMovementController.bullet--;
                zombieStatusControl.health -= gunMovementController.damage;
            }
            delay += Time.deltaTime;
            if (delay >= delayLength)
            {
                gunMovementController.bullet--;
                zombieStatusControl.health -= 10;
                audio2.Play();
                delay = 0.00001f;
            }
        }

        if (reload)
        {
            delay = 0;
            delay += Time.deltaTime;
            
            audio1.Play();
            if (delay >= 1)
            {
                gunMovementController.bullet += 8;
            }
        }
    }
}





