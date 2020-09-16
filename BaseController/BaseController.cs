using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * A BaseController is a BaseEntity representing a VR motion controller.
 * Two controllers are possessed by BasePawn to represent hands.
 */

public class BaseController : MonoBehaviour, IBaseEntity {

    /**
     * Unity method
     * Called on game start
     */

    void Start() {}

    /**
     * Unity method
     * Called on each update frame
     */

    void Update() {
        if (BaseInput.isTrigger()) { Debug.Log("Trigger pressed"); }
        if (BaseInput.isGrip()) { Debug.Log("Grip pressed"); }
        if (BaseInput.isPrimary()) { Debug.Log("Primary pressed"); }
        if (BaseInput.isSecondary()) { Debug.Log("Secondary pressed"); }
    }
}
