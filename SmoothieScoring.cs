using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothieScoring : MonoBehaviour {

	// public bool Strawberry = false;
	// public bool Kiwi = false;
	// public bool Banana = false;
	private int smoothiescore = 5;
	private GamePlayManager gameplaymanager; 
	private bool strawberry;
	private bool banana;
	private bool kiwi; 

	// Use this for initialization
	void Start () {
		gameplaymanager = GameObject.FindObjectOfType<GamePlayManager> (); 
		strawberry = false; 
		banana = false;
		kiwi = false; 
		
	}
	void OnCollisionEnter(Collision col) {
		
		if (col.gameObject.name.IndexOf ("StrawberrySmoothie") >= 0 && strawberry == false) {
			gameplaymanager.UpdateScore (smoothiescore);
			strawberry = true; 
			
		} else if (col.gameObject.name.IndexOf ("BananaSmoothie") >= 0 && banana == false) {
			gameplaymanager.UpdateScore (smoothiescore); 
			banana = true;

		} else if (col.gameObject.name.IndexOf ("KiwiSmoothie") >= 0 && kiwi == false) {
			gameplaymanager.UpdateScore (smoothiescore); 
			kiwi = true;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
