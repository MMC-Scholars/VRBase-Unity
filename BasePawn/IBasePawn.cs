/**
 * A BasePawn is a BaseEntity controlled by the player,
 * or in most cases, the VR headset and motion
 * controllers.
 */

public interface IBasePawn : IBaseEntity {

  /**
   * Unity method
   * Called on game start
   */
  void Start();

  /**
   * check and close application if requested
   */
  void checkQuit();

  /**
   * Updates the orientation of the camera
   */
  void updateCameraOrientation();

  /**
   * Unity method
   * Called on each update frame
   */
  void Update();
}
