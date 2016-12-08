using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour {

	public GameObject Floor;
	public GameObject SpawnPoint;
	Collider gameCollider;

	// Use this for initialization
	void Start () {
		gameCollider = gameObject.GetComponent<Collider> ();
	}
	
	// Update is called once per frame
	void Update () {
		
			//gameObject.transform.position = new Vector3 (gameObject.transform.position.x, 0.03f,gameObject.transform.position.z);
//		Vector3 newVect = transform.position;
//
//		newVect.y = SpawnPoint.transform.position.y;
//
//		transform.position = newVect;

		if (gameObject.transform.position.y < Floor.transform.position.y - 10f) {
			gameObject.transform.position = SpawnPoint.transform.position;
			if (gameCollider.attachedRigidbody) {
				gameCollider.attachedRigidbody.useGravity = false;
			}
			Debug.Log ("Went Behind Plank");
		}
	}

	public void SpawnPlayer(){
		gameObject.transform.position = SpawnPoint.transform.position;
		gameCollider.attachedRigidbody.useGravity = true;
		Debug.Log ("Spawn Player");
	}
}
