using UnityEngine;
using System.Collections;

public class Level3Planet2 : PlanetBase {

	// Use this for initialization
	void Start () {

		this.pull = 8;
		string movementString = "Type|startPoint|endPoint|duration|startTime|curveDepth|circleCenter|rotationAngle|radius|ccw|amplitude|frequency|phase|timeDelta|timeDeltaSum\nCurve|(0.0, 0.0, 0.0)|(-10.0, -10.0, 0.0)|2|0|(0.0, -10.0, 0.0)|(0.0, 0.0, 0.0)|0|0|False|0|0|0|0|0\nCurve|(-10.0, -10.0, 0.0)|(-10.0, 10.0, 0.0)|4|0.5|(-30.0, 0.0, 0.0)|(0.0, 0.0, 0.0)|0|14.14214|False|0|0|0|0|0\nCurve|(-10.0, 10.0, 0.0)|(0.0, 0.0, 0.0)|2|1.5|(0.0, 10.0, 0.0)|(0.0, 0.0, 0.0)|0|14.14214|False|0|0|0|0|0\nCurve|(0.0, 0.0, 0.0)|(10.0, -10.0, 0.0)|2|2|(0.0, -10.0, 0.0)|(0.0, 0.0, 0.0)|0|0|False|0|0|0|0|0\nCurve|(10.0, -10.0, 0.0)|(10.0, 10.0, 0.0)|4|2.5|(30.0, 0.0, 0.0)|(0.0, 0.0, 0.0)|0|14.14214|False|0|0|0|0|0\nCurve|(10.0, 10.0, 0.0)|(0.0, 0.0, 0.0)|2|3.5|(0.0, 10.0, 0.0)|(0.0, 0.0, 0.0)|0|14.14214|False|0|0|0|0|0\nPERIODIC|True\nREPETITIONS|0";
		movement = new Movement (this.gameObject,movementString);
		movement.ShiftMovementByPoint(new Vector2(20,-10));
		movement.Start ();
	}
}
