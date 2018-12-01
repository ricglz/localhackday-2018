using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

  void OnCollisionEnter (Collision hit) {
    if (hit.gameObject.tag == "player") {
      Player.hitPoints--;
      if(Player.hitPoints < 0) {
        Destroy(this.gameObject);
      }
		} else if(hit.gameObject.tag == "enemy") {
      Destroy(this.gameObject);
    }
  }
}
