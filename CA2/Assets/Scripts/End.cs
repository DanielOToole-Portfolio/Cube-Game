using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class End : MonoBehaviour {
	public GUISkin skin;

	void OnGUI()
	{
		GUI.skin = skin;
		GUI.Label (new Rect (30,65, 700, 90), "End of the Game");

	}
}
