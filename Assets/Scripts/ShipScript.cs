using UnityEngine;
using System.Collections;

public class ShipScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		if(GameObject.FindWithTag("Player")){
		//	Debug.Log ("Game On !");
		}else
			Debug.Log ("Game Over Man !");
		
		
			
	
	}
}
