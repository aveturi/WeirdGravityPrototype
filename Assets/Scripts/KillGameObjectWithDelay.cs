using UnityEngine;
using System.Collections;

public class KillGameObjectWithDelay : MonoBehaviour {

	int life = 400;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		life--;
		if (life == 0) {
			Destroy(this.gameObject);
		}
	}
}
