// <copyright file="GameManager.cs" company="DIS Copenhagen">
// Copyright (c) 2017 All Rights Reserved
// </copyright>
// <author>Benno Lueders</author>
// <date>14/08/2017</date>

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// In control of the game flow. Uses static fields to store information and static functions for outside communication.
/// Use this to transition between levels, request the current game state and pause/unpause the game.
/// </summary>
public class GameManager {

	public enum GameState
	{
		MainMenu,
		Running,
		Paused
	}

	public static GameState gameState;

	public static void Pause(){
		Time.timeScale = 0;
		gameState = GameState.Paused;
	}

	public static void Unpause(){
		Time.timeScale = 1;
		gameState = GameState.Running;
	}

	public static void Quit(){
		Application.Quit ();	
	}

	public static void LoadScene(string scene){
		SceneManager.LoadScene (scene);
	}
}
