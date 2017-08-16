using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class zombieMovementControl : MonoBehaviour {

    public Transform target;        //the target of the zombie 
    static Animator anim;
    public float distance = 0.2f;    //determine the attack action when the zombie closed to player
    public float speed = 0.05f;
    public Canvas healthBar;

    /*----------------------------------------------------------------------------------------------------------------------------*/

    void Start ()
    {
        anim = GetComponent<Animator>();
    }
	
	void Update ()
    {
        
        if (zombieStatusControl.health > 0)
        {
            Vector3 direction = target.position - this.transform.position;
            healthBar.transform.rotation = Quaternion.Slerp(healthBar.transform.rotation, Quaternion.LookRotation(direction), 0.1f);
            direction.y = 0;
            this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.LookRotation(direction), 0.1f);
            

            if (direction.magnitude > distance)
            {
                this.transform.Translate(0, 0, speed * Time.deltaTime);
                anim.SetBool("isAttack", false);
                anim.SetBool("isWalk", true);
            }
            else
            {
                anim.SetBool("isWalk", false);
                anim.SetBool("isAttack", true);
            }
        }
        else
        {
            anim.SetTrigger("isDead");
        }
    }

/*-------------------------------------------------------------------------------------------------------------------*/
}
