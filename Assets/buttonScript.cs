using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class buttonScript : MonoBehaviour, IVirtualButtonEventHandler{
	public GameObject VirButton;
	public GameObject taget;

	// Use this for initialization
	void Start () {
		VirButton.GetComponent<VirtualButtonBehaviour> ().RegisterEventHandler (this);
	}


	// Update is called once per frame
	void Update () {
		
	}

	public void OnButtonPressed (VirtualButtonAbstractBehaviour vb) {
		taget.GetComponent<zombieStatusControl> ().reduceHealth ();
		Debug.Log("Button on.");
	}

	public void OnButtonReleased (VirtualButtonAbstractBehaviour vb) {
		Debug.Log("Button out.");
	}

}
