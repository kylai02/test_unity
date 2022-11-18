using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CactusMove : MonoBehaviour {
  public float moveDirection = 1f;

  // Start is called before the first frame update
  void Start() {
    Invoke("KillSelf", 5f);
  }

  // Update is called once per frame
  void Update() {
    float posX = transform.position.x;
    float posY = transform.position.y;
    float posZ = transform.position.z;

    transform.position = new Vector3(posX, posY, posZ + moveDirection); 
  }

  void KillSelf() {
    Destroy(gameObject);
  }
}
