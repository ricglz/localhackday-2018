using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutomaticShoot : MonoBehaviour {

    public Rigidbody bullet;
    private int speed = -10;
    private float segundo = 1f;

    void Update () {
        segundo -= Time.deltaTime;
        if (segundo < 0) {
            Rigidbody clone = Instantiate(bullet, transform.position, transform.rotation) as Rigidbody;
            clone.velocity = transform.TransformDirection(new Vector3(speed * -1, 0, 0));
            segundo = 1f;
        }
    }
}
