using UnityEngine;
using System.Collections;

public class Level3Planet : PlanetBase {
	
	// Use this for initialization
	 void Start () {
		
		//movement = Movement.InitMovementFromUrl (this.gameObject, "http://aveturi.com/moves/FigofEightish");

		movement = new Movement (this.gameObject);
		movement.AddCurve (new Vector2 (0, 0), new Vector2 (10, 10), 4,new Vector2 (0, 10));
		movement.ChainCurve (new Vector2 (0, 0), 4,new Vector2 (10, 0));
		movement.ShiftMovementByPoint(new Vector2(-30,10));
		movement.SetRepeat ();
		movement.Start ();
	}
}
