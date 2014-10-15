using UnityEngine;
using System.Collections;

public class EnemyBase : MonoBehaviour {

	public float forceMultiplier;
	// Use this for initialization
	void Start () {
	
	}
	
	void Update () {
		GameObject player = GameObject.FindGameObjectWithTag ("Player");
		
		if (player != null) {
			Vector2 center = player.transform.position - this.transform.position;
			float distance = Vector2.Distance (this.transform.position, player.transform.position);
			
			Vector2 force = center * (1 / distance) * forceMultiplier;
			this.rigidbody2D.AddForce (force);
		}
		
	}
	
	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "Player") {
			other.gameObject.GetComponent<Character>().Damage();
		}
	}
}
