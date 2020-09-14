using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Utils contains all commonly used utility functions or
 * members.
 */

public class Utils {

    /**
     * Generates an unsigned numerical value bit shifted [shift] units,
     * or a bitfield. Created primarily for use in bitmaps or flag objects.
     */
    public static ulong BF(int shift) { return ((ulong) 1) << shift; }
}
