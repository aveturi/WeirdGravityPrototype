using UnityEngine;
using System.Collections;

public class SpaceCapsule : MonoBehaviour {

	public GameObject marker;
	Movement movement;
	// Use this for initialization
	void Start () {
		movement = new Movement (this.gameObject);
		var cam = GameObject.FindGameObjectWithTag ("MainCamera").camera;
		Vector2 bottomLeft = cam.ViewportToWorldPoint (new Vector2 (0.1f, 0.1f));
		Vector2 topRight = cam.ViewportToWorldPoint (new Vector2 (0.9f, 0.9f));

		var dur = 20;
		var ampl = 2;
		var freq = 0.5f;
		movement.AddSine (bottomLeft, topRight, dur, ampl, freq);
		movement.AddSine (topRight, bottomLeft, dur, ampl, freq);
		movement.setMarker (marker);
		movement.ToggleTrail ();
		movement.SetRepeat ();
		movement.Start ();
	}
	
	// Update is called once per frame
	void Update () {
		movement.Update ();
	}

	void OnTriggerEnter2D(Collider2D other){
		
		if (other.tag == "Player") {
			
			// apply a force towards the center
			Vector2 center = this.transform.position - other.transform.position;
			float distance = Vector2.Distance (this.transform.position, other.transform.position);
			
			Vector2 force = center * (1 / distance) * 10;
			
			other.rigidbody2D.AddForce (force);
		}
	}
	
	void OnTriggerStay2D(Collider2D other){
		OnTriggerEnter2D (other);
	}
}
