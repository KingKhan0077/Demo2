﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour {

	// Use this for initialization
	void NextScene () {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
