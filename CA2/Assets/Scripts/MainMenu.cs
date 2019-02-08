using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {
	public GUISkin skin;

	void OnGUI()
	{
		GUI.skin = skin;
		GUI.Label (new Rect (265,10, 400,90), "Cubes");
		if (GUI.Button (new Rect (350, 150, 100, 45), "Play"))
		{
			Application.LoadLevel("Level 1");
		}
		if (GUI.Button (new Rect (350, 200, 100, 45), "Quit"))
		{
			Application.Quit ();
		}
	}
}﻿