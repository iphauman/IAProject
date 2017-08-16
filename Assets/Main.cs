using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class Main : MonoBehaviour {

    public TrackableBehaviour t;
    public GameObject obj;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (t.CurrentStatus == TrackableBehaviour.Status.DETECTED) {
            obj.GetComponent<zombieStatusControl>().reduceHealth();
        }
       
	}
}
