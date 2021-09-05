using UnityEngine;
using System.Collections;


public class blocf : MonoBehaviour {
	public float startY;
	public float startX;
	public float startZ;
	// Use this for initialization
	void Start () {
	
	}
	void OnCollisionEnter (Collision other) {
		if(other.gameObject.tag == "Player") {
			other.transform.position = new Vector3(startX,startY,startZ);
		}
	}
}
