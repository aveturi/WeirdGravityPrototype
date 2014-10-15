using UnityEngine;
using System.Collections;

public class StartScreenPlanet : MonoBehaviour {
	
	Movement movement;
	// Use this for initialization
	void Start () {
		
		//movement = Movement.InitMovementFromUrl (this.gameObject, "http://aveturi.com/moves/FigofEightish");
		
		string movementString = "Type|startPoint|endPoint|duration|startTime|curveDepth|circleCenter|rotationAngle|radius|ccw|amplitude|frequency|phase|timeDelta|timeDeltaSum\nCurve|(0.0, 0.0, 0.0)|(-10.0, -10.0, 0.0)|2|0|(0.0, -10.0, 0.0)|(0.0, 0.0, 0.0)|0|0|False|0|0|0|0|0\nCurve|(-10.0, -10.0, 0.0)|(-10.0, 10.0, 0.0)|4|0.5|(-30.0, 0.0, 0.0)|(0.0, 0.0, 0.0)|0|14.14214|False|0|0|0|0|0\nCurve|(-10.0, 10.0, 0.0)|(0.0, 0.0, 0.0)|2|1.5|(0.0, 10.0, 0.0)|(0.0, 0.0, 0.0)|0|14.14214|False|0|0|0|0|0\nCurve|(0.0, 0.0, 0.0)|(10.0, -10.0, 0.0)|2|2|(0.0, -10.0, 0.0)|(0.0, 0.0, 0.0)|0|0|False|0|0|0|0|0\nCurve|(10.0, -10.0, 0.0)|(10.0, 10.0, 0.0)|4|2.5|(30.0, 0.0, 0.0)|(0.0, 0.0, 0.0)|0|14.14214|False|0|0|0|0|0\nCurve|(10.0, 10.0, 0.0)|(0.0, 0.0, 0.0)|2|3.5|(0.0, 10.0, 0.0)|(0.0, 0.0, 0.0)|0|14.14214|False|0|0|0|0|0\nPERIODIC|True\nREPETITIONS|0";
		movement = new Movement (this.gameObject,movementString);
		movement.Start ();
	}
	
	// Update is called once per frame
	void Update () {
		movement.Update ();
	}
}
