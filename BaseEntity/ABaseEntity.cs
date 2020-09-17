using UnityEngine;

/**
 * ABaseEntity is an abstract class all other entities should extend.
 * While ABaseEntity is nominally a class, it should be treated as an
 * interface for other entities to expand.
 */

public abstract class ABaseEntity : MonoBehaviour {
    /**
     * Defines how BaseEntities interact with other
     * BaseEntities. [user] represents the BaseEntity
     * that interacted with this entity, and [id]
     * represents a unique constant string that defines
     * how the entity was interacted (usually this is the
     * name of an input button).
     */
    public void OnUsed(ABaseEntity user, string id) {}
    public void OffUsed(ABaseEntity user, string id) {}
}
