using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneSelection : MonoBehaviour {
	private AppState appState;

	// Update is called once per frame
	void Start () {
		GameObject appStateObj = GameObject.Find ("AppState");
		if (appStateObj != null) {
			appState = appStateObj.GetComponent<AppState> ();
		}
	}
	public void LoadMainMenu () {
		appState.resetScore ();
		Time.timeScale = 1;
		SceneManager.LoadScene ("MainMenu");
	}
	public void LoadPauseMenu () {
		SceneManager.LoadScene ("PauseMenu");
	}
	public void LoadFailMenu () {
		SceneManager.LoadScene ("FailMenu");
	}
	public void LoadLevel (int level) {
		var sceneName = "Level" + level.ToString ();

		appState.resetScore ();
		appState.lastLevel = level;
		appState.lastLevelScene = sceneName;
		SceneManager.LoadScene(sceneName);
	}
	public void ResetLevel () {
		if (appState != null) {
			appState.resetScore();
			SceneManager.LoadScene(appState.lastLevelScene);
		}
	}
}
