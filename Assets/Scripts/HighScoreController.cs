﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class HighScoreController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	public void OnBackButtonClick() {
		SceneManager.LoadScene("MainMenu");
	}
}
