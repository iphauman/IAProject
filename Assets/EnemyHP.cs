using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHP : MonoBehaviour {
	public float hp = 100f;
	public Slider lifeBar;
	public GameObject enemy;
	// Use this for initialization
	void Start () {
		InvokeRepeating ("decreaseHealth",1f,1f);
	}
	
	// Update is called once per frame
	void Update () {
		lifeBar.value = hp;
	}

	public void decreaseHealth(){

	}
}
