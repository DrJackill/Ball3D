using UnityEngine;
using System.Collections;

public class ChangeLevel : MonoBehaviour {
	public GameObject player;
	public float distantion;
	public string levelName;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Mathf.Pow(Mathf.Pow (this.gameObject.transform.position.x - player.transform.position.x, 2) + Mathf.Pow (this.gameObject.transform.position.z - player.transform.position.z, 2), 0.5f) < distantion) 
		{
			UnityEngine.Application.LoadLevel(levelName);
		}
	}
}
