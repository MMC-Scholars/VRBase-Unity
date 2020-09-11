using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Globals {
  // since members of globals will use the namespace name Globals, we use camel
  // case immediate member names, e.g. usage will be
  // Globals.myProp
  // or
  // Globals.myClass.method()

  public static class constants {
    public const string MOUSE_X = "Mouse X";
    public const string MOUSE_Y = "Mouse Y";
  }
}
