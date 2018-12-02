using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletE : MonoBehaviour {

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
    if (hit.gameObject.tag == "Player") {
      Player.hitPoints--;
      ui.UpdateLives(Player.hitPoints);
      if(Player.hitPoints <= 0) {
        Destroy(hit.gameObject);
        Navigation.GoTo("GameOver");
      }
      Destroy(this.gameObject);
		}
  }
}
