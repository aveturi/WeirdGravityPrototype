using UnityEngine;
using System.Collections;

public class Character : MonoBehaviour {

	Vector2 vel;
	float gravityVal = -9f;
	float xSpeed = 0.5f;

	public bool invincible = false;
	private enum XState{leftWall, rightWall, noWall};
	private enum YState{upWall, downWall, noWall};

	private XState xState;
	private YState yState;

	private float yForce = 10f;
	private float xForce = 10f;

	// Use this for initialization
	void Start () {
		this.xState = XState.noWall;
		this.yState = YState.noWall;
	}
	
	// Update is called once per frame
	void Update () {
		var horz = Input.GetAxis ("Horizontal");
		var vert = Input.GetAxis ("Vertical");
		var pos = transform.position;

		
		if (horz < 0 && xState != XState.leftWall) {
			this.rigidbody2D.AddForce(-Vector2.right * xForce);
		} else if (horz > 0 && xState != XState.rightWall) {
			this.rigidbody2D.AddForce(Vector2.right * xForce);
		}
		
		if (vert > 0 && yState != YState.upWall){
			this.rigidbody2D.AddForce(Vector2.up * yForce);
		} else if (vert < 0 && yState != YState.downWall){
			this.rigidbody2D.AddForce(-Vector2.up * yForce);
		}
		
		
		transform.position = pos;
	}

	void FixedUpdate(){
		/*if (currentState != State.OnFloor) {
						// Apply gravity and acc to vel
						vel += new Vector2 (0, gravityVal) * Time.fixedDeltaTime;
		
						// Apple vel to position
						transform.position = (Vector2)transform.position + vel * Time.fixedDeltaTime;
				}*/
	}

	void OnTriggerStay2D(Collider2D other){
		OnTriggerEnter2D (other);
	}

	void OnTriggerEnter2D(Collider2D other){
		BoundaryStateCheck (other.name);
	}

	void BoundaryStateCheck(string boundaryName){
		
		if (boundaryName == "L") {
			this.xState = XState.leftWall;
		} else if (boundaryName == "R") {
			this.xState = XState.rightWall;
		} else if (boundaryName == "U") {
			this.yState = YState.upWall;
		} else if (boundaryName == "D") {
			this.yState = YState.downWall;
		}
	}

	void OnTriggerExit2D(Collider2D other){
		if (other.name == "L" || other.name == "R") {
			this.xState = XState.noWall;
		} else if (other.name == "U" || other.name == "D") {
			this.yState = YState.noWall;
		}
	}

	public void Damage(){
		if(!invincible)
			Destroy(this.gameObject);
	}
}
