using UnityEngine;
using System.Collections;

public class Level3Planet3 : PlanetBase {
	void Start () {

		this.pull = 2;
		this.movement = new Movement (this.gameObject);
		movement.AddSine (new Vector2 (-30, -20), new Vector2 (0, 0), 10, 1, 0.5f);
		movement.ChainCurve (new Vector2 (-10, -20), 5, new Vector2 (20, 70));
		movement.ChainCurve (new Vector2 (-30, -10), 5, new Vector2 (-12.5f, -30)); 
		movement.ChainCurve (new Vector2 (-10, 30), 5, new Vector2 (-60, 30));
		movement.ChainSine (new Vector2 (-30, -20), 5, 1, 0.5f);
		movement.SetRepeat ();
		movement.Start ();
	}
}
