using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasePawn : MonoBehaviour, IBaseEntity {
  const float mouseSensitivity = 1.0f;

  /**
   * Unity method
   * Called on game start
   */

  void Start() {
    // camera component
    Camera m_camera = gameObject.AddComponent<Camera>();
  }

  /**
   * updates the orientation of the camera
   */

  void updateCameraOrientation() {
    Vector3 euler = transform.rotation.eulerAngles;
    float X = euler.x;
    float Y = euler.y;

    float mouseX = Input.GetAxisRaw(Globals.constants.MOUSE_X);
    float mouseY = Input.GetAxisRaw(Globals.constants.MOUSE_Y);

    /* Debug.Log($"{mouseX}, {mouseY}"); */

    X += mouseX * mouseSensitivity * Time.deltaTime;
    Y -= mouseY * mouseSensitivity * Time.deltaTime;

    /* transform.Rotate(0.0f, mouseX, 0.0f); */
    transform.rotation = Quaternion.Euler(Y, X, 0.0f);
    Debug.Log($"{transform.rotation}");
  }

  /**
   * Unity method
   * Called on each update frame
   */

  void Update() {
    // quit scenario
    if (Input.GetKeyDown(KeyCode.Escape)) {
      Application.Quit();
      UnityEditor.EditorApplication.isPlaying = false;
    }

    // update camera rotation
    updateCameraOrientation();
  }
}
