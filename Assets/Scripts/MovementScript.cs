using UnityEngine;
using System.Collections;

public class MovementScript : MonoBehaviour {
	
	private float x;
	private float y;
	public float speed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		//y =  Input.GetAxis("Vertical")* Time.deltaTime * speed;
		x = Input.GetAxis("Horizontal")*Time.deltaTime*speed;
		
		transform.Translate(x, -0.01f, 0);
		
	}
}
