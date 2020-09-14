using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * A BaseController is a BaseEntity representing a VR motion controller.
 * Two controllers are possessed by BasePawn to represent hands.
 */

public class BaseController : MonoBehaviour, IBaseEntity {
    Bitfield m_bfButtons;

    /**
     * Unity method
     * Called on game start
     */

    void Start() { m_bfButtons = new Bitfield(); }

    /**
     * Unity method
     * Called on each update frame
     */

    void Update() {}
}
