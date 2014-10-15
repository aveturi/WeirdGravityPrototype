using UnityEngine;
using System.Collections;

public class CutScene01 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.LeftArrow) && Input.GetKey(KeyCode.RightArrow)) {
			ScoreObject score  = GameObject.FindGameObjectWithTag("GLOBALSCORE").GetComponent<ScoreObject>();
			score.gameStarted = false;
			score.playerFound = true;
			Application.LoadLevel("_Scene_1");
		}
	}
}
