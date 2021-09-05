using UnityEngine;
using System.Collections;

public class control : MonoBehaviour {
	
	// Use this for initialization
	
	// Update is called once per frame
	void level01 () {
		Time.timeScale = 1;
		Application.LoadLevel(1);
	}
	void level02 () {
		Time.timeScale = 1;
		Application.LoadLevel(2);
	}
	void level03 () {
		Time.timeScale = 1;
		Application.LoadLevel(3);
	}
	void level04 () {
		Time.timeScale = 1;
		Application.LoadLevel(4);
	}
	void level05 () {
		Time.timeScale = 1;
		Application.LoadLevel(5);
	}
	void level06 () {
		Time.timeScale = 1;
		Application.LoadLevel(6);

	}
	void level07 () {
		Time.timeScale = 1;
		Application.LoadLevel(7);
	}
	void exit () {
		Application.Quit();
	}
	void newgame () {
		level01 ();
	}
	void resume () {
				foreach (GameObject go in GameObject.FindGameObjectsWithTag("Menu")) {
						Destroy (go);
				}
				Time.timeScale = 1;
		}
}
