using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dispenser_Collision : MonoBehaviour {
	public Transform StrawberryCup;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter(Collision col) {
		if (col.gameObject.name == "group_14" || col.gameObject.name == "group_18" || col.gameObject.name == "group_8") {
			Instantiate (StrawberryCup, transform.position, transform.rotation);
			Destroy (gameObject);
		}
	}
}
