using UnityEngine;
using System.Collections;

public class Jump : MonoBehaviour {
	public GameObject player;
	public float distantion = 1;
	public float power = 10;
	public Object explosion = null;
	private bool trigger = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float g = Mathf.Pow (Mathf.Pow (this.gameObject.transform.position.x - player.transform.position.x, 2) + Mathf.Pow (this.gameObject.transform.position.z - player.transform.position.z, 2), 0.5f);
		var d = Mathf.Pow (Mathf.Pow (g, 2) + Mathf.Pow (this.gameObject.transform.position.y - player.transform.position.y, 2), 0.5f);
		if (d < distantion) {
						
			if(trigger == false){
				player.GetComponent<Rigidbody>().AddForce (new Vector3 (0, power, 0), ForceMode.Impulse);
						if (explosion != null) {
								Instantiate (explosion, transform.position, transform.rotation);
						}
				trigger = true;
			}
				} else
						trigger = false;
	}
}