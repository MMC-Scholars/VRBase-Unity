using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasePawn : MonoBehaviour, IBasePawn {
  public float mouseSensitivity = 5.0f;

  public void Start() {
    // lock mouse cursor to the window
    Cursor.lockState = CursorLockMode.Locked;

    // camera component
    Camera m_camera = gameObject.AddComponent<Camera>();
  }

  public void checkQuit() {
    bool quitScenario =
        Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.Q);

    if (quitScenario) {
      // packaged project
      Application.Quit();
      // editor development
      UnityEditor.EditorApplication.isPlaying = false;
    }
  }

  public void updateCameraOrientation() {
    float mouseX = Input.GetAxisRaw(Constants.MOUSE_X);
    float mouseY = Input.GetAxisRaw(Constants.MOUSE_Y);

    float rotXAxis = transform.eulerAngles.x;
    float rotYAxis = transform.eulerAngles.y;

    // translate x-axis rotation to a [-90, 90] range
    if (rotXAxis < 180)
      rotXAxis *= -1;
    else if (rotXAxis > 180)
      rotXAxis = 360 - rotXAxis;

    rotXAxis += mouseY * mouseSensitivity;
    rotYAxis += mouseX * mouseSensitivity;

    // x-axis transform since x axis is "upside down"
    rotXAxis = Mathf.Clamp(rotXAxis, -90, 90) * -1;

    // rotate the camera
    transform.eulerAngles = new Vector3(rotXAxis, rotYAxis, 0);
  }

  public void Update() {
    // check quit scenario
    checkQuit();

    // update camera rotation
    updateCameraOrientation();
  }
}
