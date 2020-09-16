using UnityEngine;

/**
 * ABaseEntity is an abstract class all other entities should extend.
 * While ABaseEntity is nominally a class, it should be treated as an
 * interface for other entities to expand.
 */

public abstract class ABaseEntity : MonoBehaviour {
    void OnUsed() {}
    void OffUsed() {}
}
