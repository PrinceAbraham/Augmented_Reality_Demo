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

		if (gameObject.transform.position.y < Floor.transform.position.y - 10f) {
			gameObject.transform.position = SpawnPoint.transform.position;
		}
	}
}
