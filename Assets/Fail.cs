using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Fail : MonoBehaviour {
	private AppState appState;
	private Text failUIText;
	private Text scoreUIText;
	private Text highScoreUIText;


	// Use this for initialization
	void Start () {
		GameObject appStateObj = GameObject.Find ("AppState");
		appState = appStateObj.GetComponent<AppState> ();

		GameObject failUITextObj = GameObject.Find ("Fail Text");
		scoreUIText = failUITextObj.GetComponent<Text>();
		scoreUIText.text = "Just Awful";

		GameObject scoreUITextObj = GameObject.Find ("Level Score");
		scoreUIText = scoreUITextObj.GetComponent<Text>();
		scoreUIText.text = appState.lastScore.ToString();

		GameObject highScoreUIText = GameObject.Find ("High Score");
		scoreUIText = highScoreUIText.GetComponent<Text>();
		scoreUIText.text = appState.highScore.ToString();
	}
}
