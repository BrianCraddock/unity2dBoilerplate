using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	public AppState appState;
	public SceneSelection sceneSelection;
	public bool isPaused = false;

	// Use this for initialization
	void Start () {
		GameObject appStateObj = GameObject.Find ("AppState");
		appState = appStateObj.GetComponent<AppState> ();		
	}
	
	// Update is called once per frame
	void Update () {
		if (!isPaused && Input.GetMouseButtonDown(0)) {
			var rigidBody = this.GetComponent<Rigidbody2D> ();
			var rigidBodyPosition = rigidBody.position;
			rigidBody.AddForce (transform.up * 4, ForceMode2D.Impulse);
		
			appState.updateScore(1);
		}
	}

	void OnCollisionEnter2D(Collision2D coll) {
		sceneSelection.LoadFailMenu();
	}		
}
