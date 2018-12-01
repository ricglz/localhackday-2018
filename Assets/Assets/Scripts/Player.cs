using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	Rigidbody2D rb2d;
	public static int hitPoints = 3;
	private int rotationSpeed = 120;
	private float speed = .05f;

	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		float rotation = Input.GetAxis("Horizontal") * rotationSpeed;

		rotation *= Time.deltaTime;

		transform.Rotate(0, 0, rotation);

		transform.Translate(speed * -1, 0 , 0);
	}
}
