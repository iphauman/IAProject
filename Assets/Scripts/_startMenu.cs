﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class _startMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void StartGame()
    {

        Application.LoadLevel(1);

    }

    public void Quit()
    {
        Application.Quit();
    }
}
