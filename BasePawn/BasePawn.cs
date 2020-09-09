using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasePawn : MonoBehaviour, IBaseEntity {

  void Start() {
    /* camera component */
    Camera m_camera = gameObject.AddComponent<Camera>();
  }

  void Update() {
    float mouseX = Input.GetAxis(Globals.constants.MOUSE_X);
    float mouseY = Input.GetAxis(Globals.constants.MOUSE_Y);

    if (mouseX > 0) {
      Debug.Log("+x");
    } else if (mouseX < 0) {
      Debug.Log("-x");
    }

    if (mouseY > 0) {
      Debug.Log("+y");
    } else if (mouseY < 0) {
      Debug.Log("-y");
    }
  }
}
