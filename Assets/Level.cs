using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class Level : MonoBehaviour {
	private AppState appState;
	private Text scoreUIText;
	private Text levelLabelUIText;
	private GameObject pauseMenu;
	public Player player;

	void Start () {
		pauseMenu = GameObject.Find ("Pause Panel");
		pauseMenu.SetActive (false);

		GameObject appStateObj = GameObject.Find ("AppState");
		appState = appStateObj.GetComponent<AppState> ();
		appState.lastLevelScene = SceneManager.GetActiveScene().name;

		GameObject scoreUITextObj = GameObject.Find ("Level Score");
		scoreUIText = scoreUITextObj.GetComponent<Text>();

		GameObject levelLabelUITextObj = GameObject.Find ("Level Label");
		levelLabelUIText = levelLabelUITextObj.GetComponent<Text>();
		levelLabelUIText.text = "Level " + appState.lastLevel.ToString();

	}
	
	// Update is called once per frame
	void Update () {
		scoreUIText.text = appState.lastScore.ToString();		
	}

	public void PauseGame () {
		Time.timeScale = 0;
		player.isPaused = true;
		pauseMenu.SetActive (true);
	}

	public void ResumeGame () {		
		pauseMenu.SetActive (false);
		player.isPaused = false;
		Time.timeScale = 1;
	}
}
