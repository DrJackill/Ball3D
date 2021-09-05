using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour
{
    private Vector3 inp;
    private Vector3 delta;
    private Vector3 oldPos;
	private Vector3 gravity;
    private const float pi2 = Mathf.PI * Mathf.PI;

    public float diam = 7f;

    public float speed = 7f;

    public Transform cam;
	GameObject fire;

    
	// Use this for initialization
        void Start (){
            oldPos = transform.position;
			Physics.gravity = new Vector3(0, -75, 0);
		Input.simulateMouseWithTouches=true;
        }
        
        // Update is called once per frame
        void Update ()
{

	fire = GameObject.Find("fire");
	 if (Input.GetButtonDown("Jump")){     
	//fire.particleEmitter.emit = true;
	diam = 10f;
    speed = 10f;
	 }
	 if (Input.GetButtonUp("Jump")){ 
//fire.particleEmitter.emit = false;
		 diam = 4f;

    speed = 4f;
	 }
            inp.x = Input.GetAxis("Horizontal");
            //if (Input.GetMouseButton (0))
			inp.z = Input.GetAxis ("Vertical");
//		else {
//			inp.z=0;
//			Input.ResetInputAxes();
//			//Input.GetAxis("Vertical")=0;
//			//Screen.lockCursor = true;
//				}
			
        }
    void FixedUpdate()
		{
			
        Vector3 cp = transform.position - cam.position;
        cp.y = 0f;
        transform.Translate(Quaternion.LookRotation(cp) * inp * speed * Time.deltaTime, Space.World);
		delta = oldPos - transform.position;
		if(transform.parent!=null)delta+=transform.parent.position;
        float ang = Mathf.Sin(delta.magnitude / diam / pi2) * Mathf.Rad2Deg;
        transform.RotateAround(Vector3.Cross(delta, Vector3.up), ang);
		oldPos = transform.position;
		if(transform.parent!=null)oldPos-=transform.parent.position;
}
}