using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class AppState : Singleton<AppState> {
	public int highScore = 0;
	public int lastScore = 0; 
	public int lastLevel = 0;
	public string lastLevelScene = string.Empty;

	// Use this for initialization

	void Start () {		
		transform.parent = null;
		instance = this;
		DontDestroyOnLoad (gameObject);

		highScore = PlayerPrefs.GetInt ("highScore");
	}

	public void resetScore() {
		lastScore = 0;
	}

	public void updateScore(int change) {
		lastScore = lastScore + change;

		if (lastScore > highScore) {
			highScore = lastScore;
			PlayerPrefs.SetInt ("highScore", lastScore);
		}
	}

	public int getLastScore() {
		return lastScore;
	}
}
