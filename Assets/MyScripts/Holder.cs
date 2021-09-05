using UnityEngine;
using System.Collections;

public class Holder : MonoBehaviour {
	public GameObject player;
	public float distantion = 3;
	// Use this for initialization
	private bool trigger = false;
	private Vector3 localPosition;

	void Start () {
	
	}

//	void Update () {
//		if (Mathf.Pow (Mathf.Pow (this.gameObject.transform.position.x - player.transform.position.x, 2) + Mathf.Pow (this.gameObject.transform.position.z - player.transform.position.z, 2), 0.5f) < distantion) 
//		{
//
//		}
//	}
	void OnCollisionEnter (Collision other) {
		//if(other.gameObject.tag == "Player") {
			other.transform.parent=this.transform.parent.parent;
		//}
	}
	
	void OnCollisionExit (Collision other) {
		if (other.gameObject.tag == "Player") {
						other.transform.parent = null;
				}
	}
}
