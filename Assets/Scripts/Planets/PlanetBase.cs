using UnityEngine;
using System.Collections;

public class PlanetBase : MonoBehaviour {

	protected Movement movement;
	protected float pull = 4;
	
	// Update is called once per frame
	void Update () {
		movement.Update ();
	}

	void OnTriggerEnter2D(Collider2D other){
		
		if (other.tag == "Player" || other.tag == "Enemy") {
			
			// apply a force towards the center
			Vector2 center = this.transform.position - other.transform.position;
			float distance = Vector2.Distance (this.transform.position, other.transform.position);
			
			float radius = Vector2.Distance(this.transform.position,this.renderer.bounds.max);
			
			if (distance > radius) {
				Vector2 force = center * (1 / distance) * pull;
				other.rigidbody2D.AddForce (force);
			} else {
				if(other.tag != "Player")
					Destroy (other.gameObject);
				else
					other.gameObject.GetComponent<Character>().Damage();
			}
		}
	}
	
	void OnTriggerStay2D(Collider2D other){
		OnTriggerEnter2D (other);
	}
}
