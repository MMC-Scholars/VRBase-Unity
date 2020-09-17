/**
 * Constants is a static class which holds all constant values
 * used throughout VRBase.
 */

public static class Constants {
    /* commonly used input identifiers */
    public const string MOUSE_X = "Mouse X";
    public const string MOUSE_Y = "Mouse Y";
    /* hands */
    public const string LEFT  = "LEFT";
    public const string RIGHT = "RIGHT";
    /*
     * BaseEntity used ids. Format should be WITH_identifier,
     * and contents should be the exact same as the var name
     * because we don't care about the actual content, we only
     * care that it's unique.
     */
    public const string WITH_TRIGGER = "WITH_TRIGGER";
}
