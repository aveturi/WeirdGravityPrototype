using UnityEngine;
using System.Collections;

public class UpArrowListener : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.LeftArrow) && Input.GetKey(KeyCode.RightArrow)){
			ScoreObject score  = GameObject.FindGameObjectWithTag("GLOBALSCORE").GetComponent<ScoreObject>();
			score.gameStarted = true;
			score.playerFound = true;
			Application.LoadLevel("_Scene_0");
		}
	}
}
