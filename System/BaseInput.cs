/* using System.Collections; */
/* using System.Collections.Generic; */
using UnityEngine;

/**
 * BaseInput defines all input getters for the purposes of virtual reality.
 * All input-related events should be monitored in this class.
 */

/*
 * How to add a new input:
 *
 * 1. Create a boolean getter using the format is[Key](),
 *    which returns true if the input is pressed and false otherwise
 * 2.
 */

public static class BaseInput {

    /*
     * Trigger
     */

    public static bool isLTrigger() {
        /* TODO motion controller input */
        return false;
    }

    public static bool isRTrigger() {
        /* TODO motion controller input */
        return false;
    }

    public static bool isTrigger() {
        return Input.GetKey(KeyCode.T) || Input.GetMouseButton(0) || isLTrigger() ||
               isRTrigger();
    }

    /*
     * Grip
     */

    public static bool isLGrip() {
        /* TODO motion controller input */
        return false;
    }

    public static bool isRGrip() {
        /* TODO motion controller input */
        return false;
    }

    public static bool isGrip() {
        return Input.GetKey(KeyCode.G) || isLGrip() || isRGrip();
    }

    /*
     * A
     */

    public static bool isLA() {
        /* TODO motion controller input */
        return false;
    }

    public static bool isRA() {
        /* TODO motion controller input */
        return false;
    }

    public static bool isA() { return Input.GetKey(KeyCode.A) || isLA() || isRA(); }

    /*
     * B
     */

    public static bool isLB() {
        /* TODO motion controller input */
        return false;
    }

    public static bool isRB() {
        /* TODO motion controller input */
        return false;
    }

    public static bool isB() { return Input.GetKey(KeyCode.B) || isLB() || isRB(); }

    /*
     * X
     */

    public static bool isLX() {
        /* TODO motion controller input */
        return false;
    }

    public static bool isRX() {
        /* TODO motion controller input */
        return false;
    }

    public static bool isX() { return Input.GetKey(KeyCode.X) || isLX() || isRX(); }

    /*
     * Y
     */

    public static bool isLY() {
        /* TODO motion controller input */
        return false;
    }

    public static bool isRY() {
        /* TODO motion controller input */
        return false;
    }

    public static bool isY() { return Input.GetKey(KeyCode.Y) || isLY() || isRY(); }

    /*
     * primary/secondary
     */

    public static bool isPrimary() { return isA() || isB(); }

    public static bool isSecondary() { return isX() || isY(); }

    /*
     * quit
     */

    public static bool isQuit() {
        return Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.Q);
    }
}
