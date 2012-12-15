using UnityEngine;
using System.Collections;

public class ShootScript : MonoBehaviour {
	
	public Rigidbody bullet;
	public float power = 100f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Fire1")) {
			Rigidbody clone = Instantiate(bullet, transform.position, transform.rotation) as Rigidbody;
			clone.velocity = -transform.up * power;
			Destroy(clone.gameObject,2);			
		}
		
				
		
	}
}
