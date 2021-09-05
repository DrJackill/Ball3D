using UnityEngine;
using System.Collections;

public class Rotation : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	void OnCollisionEnter (Collision other) {
		if(other.gameObject.tag == "Trap") {
			if(other.gameObject.GetComponent<Animation>()!=null)other.gameObject.GetComponent<Animation>().Play();
		}
	}
	
//	void OnCollisionExit (Collision other) {
//		if (other.gameObject.tag == "Player") {
//			other.transform.parent = null;
//		}
}
