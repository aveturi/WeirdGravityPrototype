using UnityEngine;
using System.Collections;

public class FirstPlanet : MonoBehaviour {
	
	Movement movement;
	GUIText scoreBox;
	// Use this for initialization
	void Start () {

		//movement = Movement.InitMovementFromUrl (this.gameObject, "http://aveturi.com/moves/FigofEightish");

		string movementString = "Type|startPoint|endPoint|duration|startTime|curveDepth|circleCenter|rotationAngle|radius|ccw|amplitude|frequency|phase|timeDelta|timeDeltaSum\nCurve|(0.0, 0.0, 0.0)|(-10.0, -10.0, 0.0)|2|0|(0.0, -10.0, 0.0)|(0.0, 0.0, 0.0)|0|0|False|0|0|0|0|0\nCurve|(-10.0, -10.0, 0.0)|(-10.0, 10.0, 0.0)|4|0.5|(-30.0, 0.0, 0.0)|(0.0, 0.0, 0.0)|0|14.14214|False|0|0|0|0|0\nCurve|(-10.0, 10.0, 0.0)|(0.0, 0.0, 0.0)|2|1.5|(0.0, 10.0, 0.0)|(0.0, 0.0, 0.0)|0|14.14214|False|0|0|0|0|0\nCurve|(0.0, 0.0, 0.0)|(10.0, -10.0, 0.0)|2|2|(0.0, -10.0, 0.0)|(0.0, 0.0, 0.0)|0|0|False|0|0|0|0|0\nCurve|(10.0, -10.0, 0.0)|(10.0, 10.0, 0.0)|4|2.5|(30.0, 0.0, 0.0)|(0.0, 0.0, 0.0)|0|14.14214|False|0|0|0|0|0\nCurve|(10.0, 10.0, 0.0)|(0.0, 0.0, 0.0)|2|3.5|(0.0, 10.0, 0.0)|(0.0, 0.0, 0.0)|0|14.14214|False|0|0|0|0|0\nPERIODIC|True\nREPETITIONS|0";
		movement = new Movement (this.gameObject, movementString);
		scoreBox = GameObject.FindGameObjectWithTag ("ScoreBox").guiText;
		movement.Start ();
	}
	
	// Update is called once per frame
	void Update () {
		movement.Update ();
	}

	void FixedUpdate(){
		if (scoreBox.text == "Score : 7") {
			Debug.Log("Moving on to level 2!");
		}
	}
	
	void OnTriggerEnter2D(Collider2D other){
		
		if (other.tag == "Player" || other.tag == "Enemy") {
			
			// apply a force towards the center
			Vector2 center = this.transform.position - other.transform.position;
			float distance = Vector2.Distance (this.transform.position, other.transform.position);
			
			float diameter = Mathf.Abs (this.renderer.bounds.max.x - this.renderer.bounds.min.x);
			
			if (distance >= diameter/2) {
				Vector2 force = center * (1 / distance) * 4;
				other.rigidbody2D.AddForce (force);
			} else {
				Destroy (other.gameObject);
			}
		}
	}
	
	void OnTriggerStay2D(Collider2D other){
		OnTriggerEnter2D (other);
	}
}
