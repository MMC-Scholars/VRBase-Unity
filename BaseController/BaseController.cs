using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * A BaseController is a BaseEntity representing a VR motion controller.
 * Two controllers are possessed by BasePawn to represent hands.
 */

public class BaseController : MonoBehaviour, IBaseEntity {
    public int t;

    /**
     * Unity method
     * Called on game start
     */

    void Start() { t = 0; }

    /**
     * Unity method
     * Called on each update frame
     */

    void Update() {
        Debug.Log("t = " + t);
        t = t + 1;
    }
}
