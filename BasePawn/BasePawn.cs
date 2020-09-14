using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * A BasePawn is a BaseEntity controlled by the player,
 * or in most cases, the VR headset and motion
 * controllers.
 */

public class BasePawn : MonoBehaviour, IBaseEntity {
    public float mouseSensitivity = 5.0f;

    /**
     * Unity method
     * Called on game start
     */

    void Start() {
        // lock mouse cursor to the window
        Cursor.lockState = CursorLockMode.Locked;

        // camera component
        Camera         m_camera      = gameObject.AddComponent<Camera>();
        BaseController m_lController = gameObject.AddComponent<BaseController>();
        BaseController m_rController = gameObject.AddComponent<BaseController>();
    }

    /**
     * Close application if requested
     */

    void checkQuit() {
        bool quitScenario =
            Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.Q);

        if (quitScenario) {
            // packaged project
            Application.Quit();
            // editor development
            UnityEditor.EditorApplication.isPlaying = false;
        }
    }

    /**
     * Updates the orientation of the camera
     */

    void updateCameraOrientation() {
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

    /**
     * Unity method
     * Called on each update frame
     */

    void Update() {
        // check quit scenario
        checkQuit();

        // update camera rotation
        updateCameraOrientation();
    }
}
