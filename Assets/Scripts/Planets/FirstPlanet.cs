using UnityEngine;
using System.Collections;

public class FirstPlanet : PlanetBase {

	GUIText scoreBox;
	// Use this for initialization
	void Start () {
		movement = new Movement (this.gameObject);
		movement.AddCounterClockwiseCircle (new Vector3 (-20, 0, 0), new Vector3 (0, 0, 0), Mathf.Deg2Rad * 360f, 10);
		movement.SetRepeat ();
		scoreBox = GameObject.FindGameObjectWithTag ("ScoreBox").guiText;
		movement.Start ();
	}
}
