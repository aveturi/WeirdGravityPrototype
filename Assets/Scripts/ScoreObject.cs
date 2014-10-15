using UnityEngine;
using System.Collections;

public class ScoreObject : MonoBehaviour {

	public int score = 0;

	public bool gameStarted = false;
	public bool playerFound = false;

	private bool invincible = false;
	void Awake(){
		DontDestroyOnLoad(transform.gameObject);
	}
	// Use this for initialization
	void Start () {
	
	}

	void Update () {
		// if the player gameobject is dead then load the dead scene
		GameObject player = GameObject.FindGameObjectWithTag ("Player");
		if (player == null) {
			if (gameStarted && playerFound && Application.loadedLevelName != "_Scene_Dead" && Application.loadedLevelName.StartsWith("_Scene_CutScene") == false) {
						Application.LoadLevel ("_Scene_Dead");
				}
		} else if (player != null && !gameStarted) {
			gameStarted = true;
		}

		if (player != null && Input.GetKey (KeyCode.I)) {
			Character c = player.GetComponent<Character>();
			invincible = true;
		}

		if (player != null)
						player.GetComponent<Character> ().invincible = this.invincible;

		if (score == 7 && Application.loadedLevelName == "_Scene_0") {
			Application.LoadLevel ("_Scene_CutScene01");
		} else if (score == 14 && Application.loadedLevelName == "_Scene_1") {
			Application.LoadLevel ("_Scene_CutScene12");
		}

	}
}
