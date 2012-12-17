using UnityEngine;
using System.Collections;

public class BulletScript : MonoBehaviour {
	
	public AudioClip explosion;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}
	bool hitEnemy = false;
	
	void OnTriggerEnter(Collider hit) { 
		Debug.Log("Collider hit: " + hit.gameObject.tag);
		if(hit.gameObject.tag == "Player" && !hitEnemy) {
			audio.PlayOneShot(explosion);
			Destroy(hit.gameObject);
			hitEnemy = true;
		}
		Destroy(gameObject, 1);
	}
}
