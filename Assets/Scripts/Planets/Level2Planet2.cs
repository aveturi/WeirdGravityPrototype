using UnityEngine;
using System.Collections;

public class Level2Planet2 : PlanetBase {

	GUIText scoreBox;
	// Use this for initialization
	void Start () {
		
		//movement = Movement.InitMovementFromUrl (this.gameObject, "http://aveturi.com/moves/FigofEightish");
		
		
		movement = new Movement (this.gameObject);
		
		movement.AddCounterClockwiseCircle (this.transform.position + new Vector3 (-15, 0, 0), this.transform.position, Mathf.Deg2Rad * 360f, 10);
		
		movement.SetRepeat ();
		
		
		scoreBox = GameObject.FindGameObjectWithTag ("ScoreBox").guiText;
		movement.Start ();
	}
}
