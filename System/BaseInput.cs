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
    public static bool isTrigger() {
        /* TODO motion controller input */
        return Input.GetKey(KeyCode.T) || Input.GetMouseButton(0);
    }

    public static bool isGrip() {
        /* TODO motion controller input */
        return Input.GetKey(KeyCode.G);
    }

    public static bool isA() {
        /* TODO motion controller input */
        return Input.GetKey(KeyCode.A);
    }

    public static bool isB() {
        /* TODO motion controller input */
        return Input.GetKey(KeyCode.B);
    }

    public static bool isX() {
        /* TODO motion controller input */
        return Input.GetKey(KeyCode.X);
    }

    public static bool isY() {
        /* TODO motion controller input */
        return Input.GetKey(KeyCode.Y);
    }

    public static bool isPrimary() { return isA() || isB(); }

    public static bool isSecondary() { return isX() || isY(); }
}
