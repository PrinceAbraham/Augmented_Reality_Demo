using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour {

	public GameObject Floor;
	public GameObject SpawnPoint;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
			//gameObject.transform.position = new Vector3 (gameObject.transform.position.x, 0.03f,gameObject.transform.position.z);
//		Vector3 newVect = transform.position;
//
//		newVect.y = SpawnPoint.transform.position.y;
//
//		transform.position = newVect;

		if (gameObject.transform.position.y < Floor.transform.position.y - 5f) {
			gameObject.transform.position = SpawnPoint.transform.position;
			Debug.Log ("Went Behind Plank");
		}
		Debug.Log (gameObject.transform.position);
	}

	public void SpawnPlayer(){
		gameObject.transform.position = SpawnPoint.transform.position;
		Debug.Log ("Spawn Player");
	}
}
