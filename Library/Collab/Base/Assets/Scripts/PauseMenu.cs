﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {


	public GameObject pauseMenuCanvas;
	public GameObject pauseButton;
	public GameObject scoreCanvas;
	public GameObject MainMenuCanvas;

	void Start (){

		pauseMenuCanvas.SetActive (false);
		pauseButton.SetActive (true);

	}

	public void StartGamePause () {

		Time.timeScale = 0;
		scoreCanvas.SetActive (false);


	}

	public void Pause(){

		pauseMenuCanvas.SetActive (true);
//		Debug.Log ("I should freeze");
		Time.timeScale = 0;
		pauseButton.SetActive (false);

		

	}

	public void Continue(){
		pauseMenuCanvas.SetActive (false);
		Time.timeScale = 1;
		pauseButton.SetActive (true);
		MainMenuCanvas.SetActive (false);
		scoreCanvas.SetActive (true);

	}

	public void Restart (){

		SceneManager.LoadScene ("PinBall project");
		Time.timeScale = 1;
//		pauseButton.SetActive (true);

	}

	public void End(){

		Application.Quit ();

	}
}
