using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CactusFactory : MonoBehaviour {
  public GameObject cactusL;
  public GameObject cactusM;
  public GameObject cactusS;
  public GameObject cactusAir;
  List<GameObject> cactuses = new List<GameObject>();

  // Start is called before the first frame update
  void Start() {
    cactuses.Add(cactusS);
    cactuses.Add(cactusM);
    cactuses.Add(cactusL);
    cactuses.Add(cactusAir);

    Invoke("GenerateCactus", 3f);
  }

  // Update is called once per frame
  void Update() {
    if (Input.GetKeyDown(KeyCode.X)) {
      // GenerateCactus();
    }
  }

  // Generate a cactus randomly
  void GenerateCactus() {
    int randomNum = Random.Range(0, 4);

    GameObject tmpIns;
    tmpIns = Instantiate(cactuses[randomNum]);

    if (randomNum == 3)
      tmpIns.transform.position = new Vector3(
        transform.position.x,
        transform.position.y + 2.5f,
        transform.position.z
      );
    else
      tmpIns.transform.position = transform.position;

    Invoke("GenerateCactus", Random.Range(2.5f, 3f));
  }
}
