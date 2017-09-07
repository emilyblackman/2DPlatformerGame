// <copyright file="MainMenu.cs" company="DIS Copenhagen">
// Copyright (c) 2017 All Rights Reserved
// </copyright>
// <author>Benno Lueders</author>
// <date>14/08/2017</date>

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Main menu script. Provides functionality to start and quit the game controlled by buttons from the Unity UI.
/// </summary>
public class MainMenu : MonoBehaviour {

	public string startLevelName = "Level1";

	void Start(){
		GameManager.gameState = GameManager.GameState.MainMenu;
	}

	public void StartGame(){
		GameManager.gameState = GameManager.GameState.Running;
		GameManager.LoadScene (startLevelName);
	}

	public void Quit(){
		GameManager.Quit ();
	}
}
