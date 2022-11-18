using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
  public float power = 20.20f;

  // Start is called before the first frame update
  void Start() {
        
  }

  // Update is called once per frame
  void Update() {
    if (Input.GetKeyDown(KeyCode.Space)) 
      gameObject.GetComponent<Rigidbody>().AddForce(transform.up * power);
  }

  private void OnCollisionEnter(Collision other) {
    if (other.gameObject.name != "Floor" && other.gameObject.name != "Ceiling") {
      GameObject.Find("GameManager").GetComponent<GameManager>().GameOver();
    }
  }
}