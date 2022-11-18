using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour {
  
  public float speed = 0;

  // Start is called before the first frame update
  void Start() {

  }

  // Update is called once per frame
  void Update() {
    if (Input.GetKey(KeyCode.W)) {
      MovePosition(0, 0, speed);
    }
    if (Input.GetKey(KeyCode.S)) {
      MovePosition(0, 0, -speed);
    }
    if (Input.GetKey(KeyCode.D)) {
      MovePosition(speed, 0, 0);
    }
    if (Input.GetKey(KeyCode.A)) {
      MovePosition(-speed, 0, 0);
    }
  }

  void MovePosition(float offsetX, float offsetY, float offsetZ) {
    float posX = gameObject.transform.position.x;
    float posY = gameObject.transform.position.y;
    float posZ = gameObject.transform.position.z;

    gameObject.transform.position = new Vector3(
        posX + offsetX,
        posY + offsetY,
        posZ + offsetZ
    );
  }
}
