using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

  private float timeLeft = 3;
  UI ui;

  void Start() {
    ui = GameObject.Find("Canvas").GetComponent<UI>();
  }

  void Update() {
    timeLeft -= Time.deltaTime;
    if(timeLeft <= 0) {
      Destroy(this.gameObject);
    }
  }

  void OnCollisionEnter (Collision hit) {
    Debug.LogError("Solve it");
    if (hit.gameObject.tag == "Player") {
      Player.hitPoints--;
      ui.UpdateLives(Player.hitPoints);
      if(Player.hitPoints < 0) {
        Destroy(hit.gameObject);
      }
		} else if(hit.gameObject.tag == "enemy") {
      UI.score += 100;
      Destroy(hit.gameObject);
      SpawnEnemy.CountEnemy--;
    }
    Destroy(this.gameObject);
  }
}
