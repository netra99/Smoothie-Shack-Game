using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SliceCollisions : MonoBehaviour {
	public Transform StrawberryCup;
	public Transform BananaCup;
	public Transform KiwiCup; 

	void Start() {

	}

	void OnCollisionEnter(Collision col) {
		// Debug.Log("Empty cup is colliding with "+col.gameObject.tag+":"+col.gameObject.name);
		if (col.gameObject.name.IndexOf ("StrawberryHalf") >= 0) {
			Instantiate (StrawberryCup, transform.position, transform.rotation);
			Destroy (col.gameObject);
			Destroy (gameObject);
		} else if (col.gameObject.name.IndexOf ("BananaPeeled") >= 0) {
			Instantiate (BananaCup, transform.position, transform.rotation);
			Destroy (gameObject);
			Destroy (col.gameObject);
		} else if (col.gameObject.name.IndexOf ("KiwiSlice") >= 0) {
			Instantiate (KiwiCup, transform.position, transform.rotation);
			Destroy (gameObject);
			Destroy (col.gameObject);
		}
	}
	void Update() {

	}

}
