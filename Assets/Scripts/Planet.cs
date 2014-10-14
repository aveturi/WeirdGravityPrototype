using UnityEngine;
using System.Collections;

public class Planet : MonoBehaviour {

	public GameObject marker;
	public float duration;
	public Vector3 shift; 

	Movement movement;
	// Use this for initialization
	void Start () {
		movement = new Movement (this.gameObject);
		movement.AddCounterClockwiseCircle ( transform.position + shift, transform.position, Mathf.Deg2Rad * 360, 6f);
		movement.SetRepeat ();
		movement.setMarker (marker);

		movement.Start ();
	
	}
	
	// Update is called once per frame
	void Update () {
		movement.Update ();
	}

	void OnTriggerEnter2D(Collider2D other){

		if (other.tag == "Player" || other.tag == "Enemy") {

				// apply a force towards the center
				Vector2 center = this.transform.position - other.transform.position;
				float distance = Vector2.Distance (this.transform.position, other.transform.position);

				float diameter = Mathf.Abs (this.renderer.bounds.max.x - this.renderer.bounds.min.x);

				if (distance > diameter) {
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
