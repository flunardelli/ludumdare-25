using UnityEngine;
using System.Collections;

public class BulletScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnTriggerEnter(Collider hit) { 
		Debug.Log("Collider hit: " + hit.gameObject.tag);
		if(hit.gameObject.tag == "Building") {
			Destroy(hit.gameObject);
			
		}
	}
}
