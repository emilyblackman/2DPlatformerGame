// <copyright file="PauseMenu.cs" company="DIS Copenhagen">
// Copyright (c) 2017 All Rights Reserved
// </copyright>
// <author>Benno Lueders</author>
// <date>14/08/2017</date>

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// Pause menu script. Provides functionality to Pause and Unpause the game and Go Back to the Main Menu. Controlled by buttons from the Unity UI.
/// Pressing ESC will also open and close the menu.
/// </summary>
public class PauseMenu : MonoBehaviour {

	public string mainMenuScene = "MainMenu";
	public GameObject pauseMenuCanvas;

	void Start(){
		GameManager.gameState = GameManager.GameState.Running;
		pauseMenuCanvas.SetActive (false);
	}

	void Update(){
		if (Input.GetKeyDown (KeyCode.Escape)) {
			if (GameManager.gameState == GameManager.GameState.Running) {
				Pause ();
			}
			else if (GameManager.gameState == GameManager.GameState.Paused) {
				UnPause ();
			}
		}
	}

	public void Pause(){
		pauseMenuCanvas.SetActive (true);
		GameManager.Pause ();
	}

	public void UnPause(){
		pauseMenuCanvas.SetActive (false);
		GameManager.Unpause ();
	}

	public void GoToMainMenu(){
		GameManager.gameState = GameManager.GameState.MainMenu;
		GameManager.LoadScene (mainMenuScene);
	}
}
