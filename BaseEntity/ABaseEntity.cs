using UnityEngine;

/**
 * ABaseEntity is an abstract class all other entities should extend.
 * While ABaseEntity is nominally a class, it should be treated as an
 * interface for other entities to expand.
 */

public abstract class ABaseEntity : MonoBehaviour
{

    /**
     * Extensible Start pseudo-member. It is meant to be
     * overriden instead of Start and should never be implemented here.
     */

    public virtual void BaseStart() { }

    /**
     * Unity method
     * Called on game start
     */

    void Start() { BaseStart(); }

    /**
     * Extensible Update pseudo-member. It is meant to be
     * overriden instead of Update and should never be implemented here.
     */

    public virtual void BaseUpdate() { }

    /**
     * Unity method
     * Called on game start
     */

    void Update() { BaseUpdate(); }

    /**
     * Defines how BaseEntities interact with other
     * BaseEntities. [user] represents the BaseEntity
     * that interacted with this entity, and [id]
     * represents a unique constant string that defines
     * how the entity was interacted (usually this is the
     * name of an input button).
     */

    public void onUsed(ABaseEntity user, string id) { }
    public void offUsed(ABaseEntity user, string id) { }
}
