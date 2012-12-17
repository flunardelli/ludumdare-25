using UnityEngine;
using System.Collections;

public class AAScript2 : MonoBehaviour {
	
	public Transform target;
	public Rigidbody bullet;
	public float power = 500;
	public float interval = 0.5f;
	public float lastShot = -10.0f;
	
	public int rotateXMissil = -5;
	public int rotateYMissil = 25;

	// Use this for initialization
	void Start () {
		//target = GameObject.FindWithTag("Players").transform; 
	
	}
	
	// Update is called once per frame
	void Update () {
		if(target != null){
			transform.LookAt(target);
		}
		Vector3 fwd = transform.TransformDirection (Vector3.forward);
		
		if (Physics.Raycast(transform.position, fwd, 100)){  
						
			 if(Time.time > interval + lastShot){
       			Rigidbody clone = Instantiate(bullet, transform.position,new Quaternion(transform.rotation.x+rotateXMissil, transform.rotation.y+rotateYMissil,transform.rotation.z,0)) as Rigidbody;
			 	
				clone.rigidbody.velocity = transform.forward * power;
				
    			lastShot = Time.time;
				
    		}
		}
		Debug.DrawRay(transform.position, fwd*100, Color.green);
	
	}
}
