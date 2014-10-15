using UnityEngine;
using System.Collections;

public class Coin : MonoBehaviour {

	public GameObject enemyPrefab;
	public GUIText scorebox;
	ScoreObject scoreObject;



	// Use this for initialization
	void Start () {
		scoreObject = GameObject.FindGameObjectWithTag ("GLOBALSCORE").GetComponent<ScoreObject> ();
		scorebox.text = "Score : "+scoreObject.score;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if(this.transform.localScale.x <= 10 && this.transform.localScale.y <=10)
		this.transform.localScale = this.transform.localScale * 1.1f;
		else
			this.transform.localScale = this.transform.localScale * 0.9f;
	}

	void OnTriggerEnter2D(Collider2D other){
		
		if (other.tag == "Player") {
			
			//put it somewhere else
			var cam = GameObject.FindGameObjectWithTag("MainCamera").camera;
			float screenX = Random.Range(0.1f, 0.9f);
			float screenY = Random.Range(0.1f, 0.9f);
			Vector2 point = cam.ViewportToWorldPoint(new Vector2(screenX,screenY));
			this.transform.position = point;
			scoreObject.score++;

			GameObject enemy = Instantiate(enemyPrefab) as GameObject;



			enemy.transform.position = generateEnemyPos(cam);

			scorebox.text = "Score : "+scoreObject.score;
		}
	}

	Vector3 generateEnemyPos(Camera cam){

		Vector3 pos = cam.ViewportToWorldPoint(new Vector2(Random.Range(0.0f, 1.0f),Random.Range(0.0f, 1.0f)));
		pos.z = 0;
		GameObject player = GameObject.FindGameObjectWithTag ("Player");

		while(Vector3.Distance (player.transform.position, pos) < 1) {
			pos = cam.ViewportToWorldPoint(new Vector2(Random.Range(0.0f, 1.0f),Random.Range(0.0f, 1.0f)));
			pos.z = 0;
		}

		return pos;
	}

}
