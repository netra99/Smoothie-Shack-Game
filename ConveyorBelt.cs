using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConveyorBelt : MonoBehaviour {

	public GameObject belt;
	public Transform endpoint;
	public float speed;
	public float visualSpeedScalar;
	public float currentScroll;
	public bool isAlongX;

	void Update() {
		/* This scrolls the conveyor belt pattern in time with the movement of the belt. */
		currentScroll = currentScroll + Time.deltaTime * visualSpeedScalar;
		if (isAlongX) {
			GetComponent<Renderer> ().material.mainTextureOffset = new Vector2 (currentScroll, 0);
		} 
		else {
			GetComponent<Renderer> ().material.mainTextureOffset = new Vector2 (0, currentScroll);
		}
	}

	void OnTriggerStay(Collider other) {
		other.transform.position = Vector3.MoveTowards (other.transform.position, endpoint.position, speed * Time.deltaTime);
	}
}
