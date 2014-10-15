using UnityEngine;
using System.Collections;

public class Planet : PlanetBase {

	public GameObject marker;
	public float duration;
	public Vector3 shift; 

	// Use this for initialization
	void Start () {
		movement = new Movement (this.gameObject);
		movement.AddCounterClockwiseCircle ( transform.position + shift, transform.position, Mathf.Deg2Rad * 360, 6f);
		movement.SetRepeat ();

		movement.Start ();
	
	}
}
