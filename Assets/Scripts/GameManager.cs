using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;


public class GameManager : MonoBehaviour {
  public GameObject factory;
  public bool isPlaying = false;

  public int score = 0;
  public float time_f = 0;

  public GameObject state_gamestart;
  public GameObject state_game;
  public GameObject state_gameover;

  public TMP_Text gameTimeUI;
  public TMP_Text gameScoreUI;

  // Start is called before the first frame update
  void Start() {
        
  }

  // Update is called once per frame
  void Update() {
    if (Input.GetKeyDown(KeyCode.A))
      GameStart();
    if (Input.GetKeyDown(KeyCode.S))
      Restart(); 
    
    if (isPlaying) {
      time_f += Time.deltaTime;
      score = (int)time_f;
      gameTimeUI.text = time_f.ToString();
      gameScoreUI.text = score.ToString();
    }
  }

  public void GameStart() {
    Debug.Log("Game Start");
    factory.SetActive(true);
    isPlaying = true;

    state_gamestart.SetActive(false);
    state_game.SetActive(true);
  }

  public void GameOver() {
    if (isPlaying) {
      Debug.Log("Game Over");
      factory.SetActive(false);
      isPlaying = false;

      state_game.SetActive(false);
      state_gameover.SetActive(true);
    }
  }

  public void Restart() {
    SceneManager.LoadScene(0);
  }
}
