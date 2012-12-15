using UnityEngine;
using System.Collections;

public class AAScript : MonoBehaviour {
	
	public Transform target;
	public Rigidbody bullet;
	public float power = 3000;
	public float interval = 0.5f;
	public float lastShot = -10.0f;

	// Use this for initialization
	void Start () {
		target = GameObject.FindWithTag("Player").transform; 
	
	}
	
	// Update is called once per frame
	void Update () {
		
		Vector3 fwd = transform.TransformDirection (Vector3.up);
		
		if (Physics.Raycast(transform.position, fwd, 10)){  
						
			 if(Time.time > interval + lastShot){
       			Rigidbody clone = Instantiate(bullet, transform.position,transform.rotation) as Rigidbody;
			 	//instance.AddForce(fwd * power);
				clone.velocity = transform.up * power;
				//audio.PlayOneShot(colt);
    			lastShot = Time.time;
				Destroy(clone.gameObject, 1);
    		}
		}
	
	}
}
