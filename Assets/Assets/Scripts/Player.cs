using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    Rigidbody2D rb2d;
    public static int hitPoints;
    private int rotationSpeed = 200;
    private float speed = .05f;

    private Camera cam;
    private float height;
    private float width;

    // Use this for initialization
    void Start () {
        hitPoints = 3;
        rb2d = GetComponent<Rigidbody2D> ();
        cam = Camera.main;
        height = cam.orthographicSize;
        width = height * cam.aspect;
    }

    // Update is called once per frame
    void Update () {
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed * -1;

        rotation *= Time.deltaTime;

        transform.Rotate(0, 0, rotation);

        transform.Translate(speed * -1, 0 , 0);

        //will stop when reaching borders
         if (transform.position.x <= -width) {
             transform.position = new Vector2(-width, transform.position.y);
         } else if (transform.position.x >= width) {
             transform.position = new Vector2(width, transform.position.y);
         }
         if (transform.position.y <= -height) {
             transform.position = new Vector2(transform.position.x, -height);
         } else if (transform.position.y >= height) {
             transform.position = new Vector2(transform.position.x, height);
         }
    }
}
