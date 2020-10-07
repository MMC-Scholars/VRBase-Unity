/* using System.Collections; */
/* using System.Collections.Generic; */
using UnityEngine;

/**
 * BaseInput defines all input getters for the purposes of virtual reality.
 * All input-related events should be monitored in this class.
 */

public static class BaseInput
{

    /*
     * Trigger
     */

    public static bool isLTriggerPressed()
    {
        /* TODO motion controller input */
        return false;
    }

    public static bool isRTriggerPressed()
    {
        /* TODO motion controller input */
        return false;
    }

    public static bool isTriggerPressed()
    {
        return Input.GetKeyDown(KeyCode.T) || Input.GetMouseButtonDown(0) ||
               isLTriggerPressed() || isRTriggerPressed();
    }

    public static bool isLTriggerReleased()
    {
        /* TODO motion controller input */
        return false;
    }

    public static bool isRTriggerReleased()
    {
        /* TODO motion controller input */
        return false;
    }

    public static bool isTriggerReleased()
    {
        return Input.GetKeyUp(KeyCode.T) || Input.GetMouseButtonUp(0) ||
               isLTriggerReleased() || isRTriggerReleased();
    }

    /*
     * Grip
     */

    public static bool isLGripPressed()
    {
        /* TODO motion controller input */
        return false;
    }

    public static bool isRGripPressed()
    {
        /* TODO motion controller input */
        return false;
    }

    public static bool isGripPressed()
    {
        return Input.GetKeyDown(KeyCode.G) || isLGripPressed() || isRGripPressed();
    }

    public static bool isLGripReleased()
    {
        /* TODO motion controller input */
        return false;
    }

    public static bool isRGripReleased()
    {
        /* TODO motion controller input */
        return false;
    }

    public static bool isGripReleased()
    {
        return Input.GetKeyUp(KeyCode.G) || isLGripReleased() || isRGripReleased();
    }

    /*
     * A
     */

    public static bool isLAPressed()
    {
        /* TODO motion controller input */
        return false;
    }

    public static bool isRAPressed()
    {
        /* TODO motion controller input */
        return false;
    }

    public static bool isAPressed()
    {
        return Input.GetKeyDown(KeyCode.A) || isLAPressed() || isRAPressed();
    }

    public static bool isLAReleased()
    {
        /* TODO motion controller input */
        return false;
    }

    public static bool isRAReleased()
    {
        /* TODO motion controller input */
        return false;
    }

    public static bool isAReleased()
    {
        return Input.GetKeyUp(KeyCode.A) || isLAReleased() || isRAReleased();
    }

    /*
     * B
     */

    public static bool isLBPressed()
    {
        /* TODO motion controller input */
        return false;
    }

    public static bool isRBPressed()
    {
        /* TODO motion controller input */
        return false;
    }

    public static bool isBPressed()
    {
        return Input.GetKeyDown(KeyCode.B) || isLBPressed() || isRBPressed();
    }

    public static bool isLBReleased()
    {
        /* TODO motion controller input */
        return false;
    }

    public static bool isRBReleased()
    {
        /* TODO motion controller input */
        return false;
    }

    public static bool isBReleased()
    {
        return Input.GetKeyUp(KeyCode.B) || isLBReleased() || isRBReleased();
    }

    /*
     * X
     */

    public static bool isLXPressed()
    {
        /* TODO motion controller input */
        return false;
    }

    public static bool isRXPressed()
    {
        /* TODO motion controller input */
        return false;
    }

    public static bool isXPressed()
    {
        return Input.GetKeyDown(KeyCode.X) || isLXPressed() || isRXPressed();
    }

    public static bool isLXReleased()
    {
        /* TODO motion controller input */
        return false;
    }

    public static bool isRXReleased()
    {
        /* TODO motion controller input */
        return false;
    }

    public static bool isXReleased()
    {
        return Input.GetKeyUp(KeyCode.X) || isLXReleased() || isRXReleased();
    }

    /*
     * Y
     */

    public static bool isLYPressed()
    {
        /* TODO motion controller input */
        return false;
    }

    public static bool isRYPressed()
    {
        /* TODO motion controller input */
        return false;
    }

    public static bool isYPressed()
    {
        return Input.GetKeyDown(KeyCode.Y) || isLYPressed() || isRYPressed();
    }

    public static bool isLYReleased()
    {
        /* TODO motion controller input */
        return false;
    }

    public static bool isRYReleased()
    {
        /* TODO motion controller input */
        return false;
    }

    public static bool isYReleased()
    {
        return Input.GetKeyUp(KeyCode.Y) || isLYReleased() || isRYReleased();
    }

    /*
     * primary/secondary
     */

    public static bool isPrimaryPressed() { return isAPressed() || isBPressed(); }

    public static bool isSecondaryPressed() { return isXPressed() || isYPressed(); }

    public static bool isPrimaryReleased() { return isAReleased() || isBReleased(); }

    public static bool isSecondaryReleased()
    {
        return isXReleased() || isYReleased();
    }

    /*
     * quit
     */

    public static bool isQuitPressed()
    {
        return Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.Q);
    }
}
