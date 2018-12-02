using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour {

  public Text txtScore;
  public GameObject heart1, heart2, heart3;
  public static float score = 0;

  void Start() {
    heart1.gameObject.SetActive(true);
    heart2.gameObject.SetActive(true);
    heart3.gameObject.SetActive(true);
  }

  void Update() {
    score += Time.deltaTime * 5;
    txtScore.text = "Score: " + ((int) score);
  }

  public void UpdateLives(int livesLeft) {
    if(livesLeft == 2) {
      heart3.gameObject.SetActive(false);
    } else if(livesLeft == 1) {
      heart2.gameObject.SetActive(false);
    } else {
      heart1.gameObject.SetActive(false);
    }
  }
}
