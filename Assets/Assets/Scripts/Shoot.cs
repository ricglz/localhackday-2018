using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

  public Rigidbody2D bullet;
  private int speed = -10;

  void Update () {
    if (Input.GetKeyDown(KeyCode.Space)) {
      Rigidbody2D clone = Instantiate(bullet, transform.position, transform.rotation) as Rigidbody2D;
      clone.velocity = transform.TransformDirection(new Vector3(speed, 0, 0));
    }
  }
}
