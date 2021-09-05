using UnityEngine;
using System.Collections;

public class backmenu : MonoBehaviour {

	// Use this for initialization
	// Update is called once per frame
	void back () {
		Time.timeScale = 1;
		Application.LoadLevel(0);
	}
}