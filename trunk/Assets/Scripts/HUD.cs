using UnityEngine;
using System.Collections;

public class HUD : MonoBehaviour {
	
	GUIStyle style;
	public Font font;
	
	int ships = 12;
	private float meters = 0f;
	enum state {Game, GameOver, Complete};
	
	state currentState;
	
	// Use this for initialization
	void Start () {
		style = new GUIStyle();
		style.font = font;
		style.normal.textColor = Color.white;
		style.fontSize = 22;
		Debug.Log("HUD anter");
		currentState = state.Game;
	}
	
	// Update is called once per frame
	void Update () {
		meters = transform.position.y * 2;
		ships = GameObject.FindGameObjectsWithTag("Player").Length;	
		if (ships > 0){
		//	Debug.Log ("Game On !");
			if (meters < 1.7) {
				Debug.Log ("invasion complete");
				currentState = state.Complete;
			}
		} else{
			currentState = state.GameOver;
		}
	}
	
	
	void OnGUI () {
		//GUILayout.BeginArea (new Rect (0,0,Screen.width,Screen.height));
		
		GUILayout.Space(10);
		GUILayout.BeginHorizontal(GUILayout.Width(Screen.width));
			GUILayout.FlexibleSpace();
				GUILayout.Space(10);
				GUILayout.Label("Ships: "+ships,style);
				GUILayout.FlexibleSpace();
				if (meters < 10) {
					style.normal.textColor = Color.red;	
				} else {
					style.normal.textColor = Color.white;		
				}
				GUILayout.Label("Meters: "+meters.ToString("n2")+"m",style);
				GUILayout.Space(10);
		GUILayout.FlexibleSpace();
		GUILayout.EndHorizontal();
		
		if (currentState == state.GameOver){
			GUILayout.BeginHorizontal(GUILayout.Width(Screen.width),GUILayout.Height(Screen.height));
			GUILayout.FlexibleSpace();	
			GUILayout.BeginVertical();
				GUILayout.FlexibleSpace();
					GUILayout.Label("Game Over",style);			
						if (GUI.Button(new Rect(Screen.width/2 - 200 / 2, Screen.height /2  + 150 /2, 200,50),"Try again")){
				            Application.LoadLevel("scene1");
				        }
				GUILayout.FlexibleSpace();
			GUILayout.EndVertical();
			GUILayout.FlexibleSpace();
			GUILayout.EndHorizontal();			
			
		} else if (currentState == state.Complete) {
			GUILayout.BeginHorizontal(GUILayout.Width(Screen.width),GUILayout.Height(Screen.height));
			GUILayout.FlexibleSpace();	
			GUILayout.BeginVertical();
				GUILayout.FlexibleSpace();
					GUILayout.Label("Invasion Complete",style);			
						if (GUI.Button(new Rect(Screen.width/2 - 200 / 2, Screen.height /2  + 150 /2, 200,50),"Play again")){
				            Application.LoadLevel("scene1");
				        }
				GUILayout.FlexibleSpace();
			GUILayout.EndVertical();

			GUILayout.FlexibleSpace();
			GUILayout.EndHorizontal();
			
		}
		
		
		
	}
}
