using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMove : MonoBehaviour {
	public GameObject obj;	
	public float timer;
	public int newtarget = 5;
	public float speed = 5;
	public Vector3 target;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		if (timer >= newtarget) {
			newTarget ();
			timer = 0;
		}
	}

	void newTarget(){
		float myX = gameObject.transform.position.x;
		//float myZ = gameObject.transform.position.z;

		float xPos = myX + Random.Range (myX - 5, myX + 5);
		//float zPos = myZ + Random.Range (myZ - 5, myZ + 5);
	
		target = new Vector3 (xPos, gameObject.transform.position.y, gameObject.transform.position.z);

		obj.transform.position = target;
	}

}
