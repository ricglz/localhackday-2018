using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

  public Rigidbody bullet;
  private float nextFire = 0.0f;
  private float fireRate = 1;

  void Update () {
    if (Input.GetButton("Fire1") && Time.time > nextFire){
      nextFire = Time.time + fireRate;
      Instantiate(bullet, transform.position, transform.rotation);
    }
  }
}
