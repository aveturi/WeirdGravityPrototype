using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		GameObject player = GameObject.FindGameObjectWithTag ("Player");

		if (player != null) {
						Vector2 center = player.transform.position - this.transform.position;
						float distance = Vector2.Distance (this.transform.position, player.transform.position);

						Vector2 force = center * (1 / distance) * 4;
						this.rigidbody2D.AddForce (force);
		}

	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "Player") {
			Destroy(other.gameObject);
		}
	}
}
