using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasePawn : MonoBehaviour, IBaseEntity {
  /* TODO remove test */
  int t;

  void Start() {
    /* camera component */
    Camera camera = gameObject.AddComponent<Camera>();

    /* TODO remove test */
    t = 0;
  }

  void Update() {
    /* TODO remove test */
    Debug.Log("time = " + t);
    t = t + 1;
  }
}
