using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	Rigidbody2D rb2d;
	static int hitPoints = 3;

	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.A)) {
			transform.Rotate (Vector3.forward * Time.deltaTime);
		} else if(Input.GetKeyDown(KeyCode.D)) {
			transform.Rotate (Vector3.back * Time.deltaTime);
		}
	}
}
