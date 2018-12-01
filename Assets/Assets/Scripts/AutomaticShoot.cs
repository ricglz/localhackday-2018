using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutomaticShoot : MonoBehaviour {

    public Rigidbody2D bullet;
    private int speed = -10;
    private float segundo = 1f;

    void Update () {
        segundo -= Time.deltaTime;
        if (segundo < 0) {
            Rigidbody2D clone = Instantiate(bullet, transform.position, transform.rotation) as Rigidbody2D;
            float rand_z = Random.Range(-10, 10);
            clone.velocity = transform.TransformDirection(new Vector3(speed * -1, rand_z, 0));
            segundo = 1f;
        }
    }
}
