using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MainMenu : MonoBehaviour {
	private AppState appState;
	private Text highScoreUIText;
	// Use this for initialization
	void Start () {
		GameObject appStateObj = GameObject.Find ("AppState");
		appState = appStateObj.GetComponent<AppState> ();

		GameObject scoreUITextObj = GameObject.Find ("High Score");
		highScoreUIText = scoreUITextObj.GetComponent<Text>();

		highScoreUIText.text = "Best: " + PlayerPrefs.GetInt("highScore").ToString();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
