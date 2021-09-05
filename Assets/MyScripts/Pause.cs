using UnityEngine;
using System.Collections;

public class Pause : MonoBehaviour {
	// Update is called once per frame
	private bool pause;
	void Update () {
		if (Input.GetKeyDown(KeyCode.Escape)) {  //2
			if(!pause){
				Time.timeScale = 0;
				pause = true;
				Application.LoadLevelAdditive(8);
			}
			else
			{
				foreach(GameObject go in GameObject.FindGameObjectsWithTag("Menu"))
				{
					Destroy(go);
				}
				Time.timeScale = 1;
				pause=false;
			}
				}

	}
}
