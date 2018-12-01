using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

  private float timeLeft = 3;

  void Update() {
    timeLeft -= Time.deltaTime;
    if(timeLeft <= 0) {
      Destroy(this.gameObject);
    }
  }

  void OnCollisionEnter (Collision hit) {
    if (hit.gameObject.tag == "Player") {
      Player.hitPoints--;
      UI.UpdateLives(Player.hitPoints);
      if(Player.hitPoints < 0) {
        Destroy(this.gameObject);
      }
		} else if(hit.gameObject.tag == "enemy") {
      UI.score += 100;
      Destroy(this.gameObject);
    }
  }
}
