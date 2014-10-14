using UnityEngine;
using System.Collections;

public class Boundary : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerStay2D(Collider2D other){
		//OnTriggerEnter2D (other);                                       
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "Player" || other.tag == "Enemy") {
			Debug.Log ("boundary was hit");

			other.rigidbody2D.velocity = Vector2.zero;

			if(this.name == "L"){
				other.transform.position = new Vector3(this.renderer.bounds.max.x, other.transform.position.y, other.transform.position.z);
			} else if(this.name == "R"){
				other.transform.position = new Vector3(this.renderer.bounds.min.x, other.transform.position.y, other.transform.position.z);
			} else if(this.name == "U"){
				other.transform.position = new Vector3(other.transform.position.x, this.renderer.bounds.min.y, other.transform.position.z);
			} else if(this.name == "D"){
				other.transform.position = new Vector3(other.transform.position.x, this.renderer.bounds.max.y, other.transform.position.z);
			}
		}
	}
}
