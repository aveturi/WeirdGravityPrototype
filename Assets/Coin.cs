using UnityEngine;
using System.Collections;

public class Coin : MonoBehaviour {

	public GameObject enemyPrefab;
	public GUIText scorebox;

	int coinsCollected = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other){
		
		if (other.tag == "Player") {
			
			//put it somewhere else
			var cam = GameObject.FindGameObjectWithTag("MainCamera").camera;
			float screenX = Random.Range(0.1f, 0.9f);
			float screenY = Random.Range(0.1f, 0.9f);
			Vector2 point = cam.ViewportToWorldPoint(new Vector2(screenX,screenY));
			this.transform.position = point;
			coinsCollected++;

			GameObject enemy = Instantiate(enemyPrefab) as GameObject;

			Vector3 pos = cam.ViewportToWorldPoint(new Vector2(Random.Range(0.0f, 1.0f),Random.Range(0.0f, 1.0f)));
			pos.z = 0;
			enemy.transform.position = pos;

			scorebox.text = "Score : "+coinsCollected;
		}
	}
}
