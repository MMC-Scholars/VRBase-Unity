using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * A BaseController is a BaseEntity representing a VR motion controller.
 * Two controllers are possessed by BasePawn to represent hands.
 */

public class BaseController : ABaseEntity {
    // arbitrary assignment - this cannot be null
    private string m_sHand = Constants.LEFT;

    /**
     * Determines which hand (left or right) this controller represents.
     */

    public string getHand() { return m_sHand; }
    public void   setHand(string hand) { m_sHand = hand; }

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
        /* TODO */
        /* Debug.Log($"hand is {m_sHand}"); */
    }
}
