using UnityEngine;
using System.Collections;

public class CutScene01Planet : MonoBehaviour {


	Movement m;
	public Vector2 shiftPoint;
	// Use this for initialization
	void Start () {

		var movementString = "Type|startPoint|endPoint|duration|startTime|curveDepth|circleCenter|rotationAngle|radius|ccw|amplitude|frequency|phase|timeDelta|timeDeltaSum\nCurve|(-5.0, 5.0, 0.0)|(0.0, 5.0, 0.0)|1|0|(-2.5, 10.0, 0.0)|(0.0, 0.0, 0.0)|0|7.071068|False|0|0|0|0|0\nCurve|(0.0, 5.0, 0.0)|(5.0, 5.0, 0.0)|1|0|(2.5, 10.0, 0.0)|(0.0, 0.0, 0.0)|0|5|False|0|0|0|0|0\nCurve|(5.0, 5.0, 0.0)|(10.0, 5.0, 0.0)|1|0|(7.5, 10.0, 0.0)|(0.0, 0.0, 0.0)|0|7.071068|False|0|0|0|0|0\nCurve|(10.0, 5.0, 0.0)|(2.5, -15.0, 0.0)|2|0|(12.0, 0.0, 0.0)|(0.0, 0.0, 0.0)|0|11.18034|False|0|0|0|0|0\nCircle|(2.5, -15.0, 0.0)|(2.5, -15.0, 0.0)|1|0|(0.0, 0.0, 0.0)|(2.5, -18.0, 0.0)|6.283185|3|True|0|0|0|0|0\nCurve|(2.5, -15.0, 0.0)|(-5.0, 5.0, 0.0)|2|0|(-7.0, 0.0, 0.0)|(0.0, 0.0, 0.0)|0|15.20691|False|0|0|0|0|0\nPERIODIC|True\nREPETITIONS|0";
		m = new Movement (this.gameObject, movementString);
		m.ShiftMovementByPoint (shiftPoint);
		m.Start ();
	}
	
	// Update is called once per frame
	void Update () {
		m.Update ();
	}
}
