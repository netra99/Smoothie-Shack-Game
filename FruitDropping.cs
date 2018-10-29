using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitDropping : MonoBehaviour {
	public Transform EmptyCup_1; 
	// Music from: https://www.bensound.com 
	public AudioClip MusicClip;
	public AudioSource MusicSource; 


	// Use this for initialization
	IEnumerator Start () {
		MusicSource.clip = MusicClip;
		MusicSource.Play (); 

		Instantiate (EmptyCup_1, transform.position, transform.rotation); 
		yield return new WaitForSeconds (1);
		Instantiate (EmptyCup_1, transform.position, transform.rotation); 
		yield return new WaitForSeconds (1);
		Instantiate (EmptyCup_1, transform.position, transform.rotation); 

		Object[] Whole_fruits = Resources.LoadAll ("WholeFruit", typeof(GameObject));
		foreach(GameObject fruit in Whole_fruits) {
			yield return new WaitForSeconds (2);
			GameObject drop = (GameObject)fruit;
			Instantiate (drop, transform.position, transform.rotation);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
