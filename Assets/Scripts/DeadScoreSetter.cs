using UnityEngine;
using System.Collections;

public class DeadScoreSetter : MonoBehaviour {

	public GUIText scoreBox;
	// Use this for initialization
	void Start () {
		var scoreObject = GameObject.FindGameObjectWithTag ("GLOBALSCORE").GetComponent<ScoreObject> ();
		scoreBox.text = "Score : " + scoreObject.score;
	}

	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.LeftArrow) && Input.GetKey(KeyCode.RightArrow)) {
			var scoreObject = GameObject.FindGameObjectWithTag ("GLOBALSCORE").GetComponent<ScoreObject> ();

			if(scoreObject.score >= 14){
				Application.LoadLevel("_Scene_2");
				scoreObject.score = 14;
			} else if(scoreObject.score >= 7){
			Application.LoadLevel("_Scene_1");
				scoreObject.score = 7;
			} else {
				Application.LoadLevel("_Scene_0");
				scoreObject.score = 0;
			}
		}
	}
}
