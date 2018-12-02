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

  void OnTriggerEnter2D (Collider2D hit) {
    if(hit.gameObject.tag == "Enemy") {
      UI.score += 100;
      Destroy(hit.gameObject);
      SpawnEnemy.CountEnemy--;
      Destroy(this.gameObject);
    }
  }
}
