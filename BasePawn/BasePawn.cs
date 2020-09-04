using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasePawn : MonoBehaviour, IBaseEntity {
  int t;

  void Start() { t = 0; }

  void Update() {
    Debug.Log("time = " + t);
    t = t + 1;
  }
}
