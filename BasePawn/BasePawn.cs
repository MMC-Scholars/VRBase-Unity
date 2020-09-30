using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * A BasePawn is a BaseEntity controlled by the player,
 * or in most cases, the VR headset and motion
 * controllers.
 */

public class BasePawn : ABaseEntity {
    // public props
    public float mouseSensitivityScale = 5.0f;

    // components
    Camera         m_camera;
    BaseController m_lController;
    BaseController m_rController;

    /**
     * Unity method
     * Called on game start
     */

    void Start() {
        // lock mouse cursor to the window
        Cursor.lockState = CursorLockMode.Locked;

        m_camera = gameObject.AddComponent<Camera>();

        m_lController = gameObject.AddComponent<BaseController>();
        m_lController.setHand(Constants.LEFT);

        m_rController = gameObject.AddComponent<BaseController>();
        m_rController.setHand(Constants.RIGHT);

        BaseStart();
    }

    /**
     * Close application if requested
     */

    void checkQuit() {
        if (BaseInput.isQuitPressed()) {
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

        rotXAxis += mouseY * mouseSensitivityScale;
        rotYAxis += mouseX * mouseSensitivityScale;

        // x-axis transform since x axis is "upside down"
        rotXAxis = Mathf.Clamp(rotXAxis, -90, 90) * -1;

        // rotate the camera
        transform.eulerAngles = new Vector3(rotXAxis, rotYAxis, 0);
    }

    /**
     * Extensible UpdateInput pseudo-member. It is meant to be
     * overriden instead of UpdateInput and should never be implemented here.
     */

    public virtual void BaseUpdateInput() {}

    /**
     * Update controller inputs and call any actions as needed.
     */

    public void UpdateInput() {
        // TODO add default pickup/interact behavior

        // call child input updates
        BaseUpdateInput();
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

        // update all input listeners
        UpdateInput();

        // call child updates
        BaseUpdate();
    }
}
