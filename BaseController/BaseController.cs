using UnityEngine;

/**
 * A BaseController is a BaseEntity representing a VR motion controller.
 * Two controllers are possessed by BasePawn to represent hands.
 */

public class BaseController : ABaseEntity {
    // arbitrary assignment - this cannot be null
    private string   m_sHand = Constants.LEFT;
    private Bitfield m_bfButtons;

    // bitmasks - can't declare these as constants since
    // they technically have a "variable output"
    private ulong BM_TRIGGER_PRESSED  = Bitfield.mask(0);
    private ulong BM_TRIGGER_RELEASED = Bitfield.mask(1);
    private ulong BM_GRIP_PRESSED     = Bitfield.mask(2);
    private ulong BM_GRIP_RELEASED    = Bitfield.mask(3);
    private ulong BM_A_PRESSED        = Bitfield.mask(4);
    private ulong BM_A_RELEASED       = Bitfield.mask(5);
    private ulong BM_B_PRESSED        = Bitfield.mask(6);
    private ulong BM_B_RELEASED       = Bitfield.mask(7);
    private ulong BM_X_PRESSED        = Bitfield.mask(8);
    private ulong BM_X_RELEASED       = Bitfield.mask(9);
    private ulong BM_Y_PRESSED        = Bitfield.mask(10);
    private ulong BM_Y_RELEASED       = Bitfield.mask(11);

    /**
     * Unity method
     * Called on game start
     */

    void Start() {
        m_bfButtons = new Bitfield();
        BaseStart();
    }

    /**
     * Update controller inputs in bitfield. This should ONLY be called
     * by the host, i.e. BasePawn.
     */

    public void updateInput() {
        switch (m_sHand) {

        case Constants.LEFT:
            /* TODO add compatibility for VR inputs */
            /* if (BaseInput.isLTriggerPressed())
             * m_bfButtons.apply(BM_TRIGGER_PRESSED); */
            /* if (BaseInput.isLTriggerReleased()) */
            /*     m_bfButtons.apply(BM_TRIGGER_RELEASED); */
            /* if (BaseInput.isLGripPressed()) m_bfButtons.apply(BM_GRIP_PRESSED); */
            /* if (BaseInput.isLGripReleased()) m_bfButtons.apply(BM_GRIP_RELEASED);
             */
            /* if (BaseInput.isLAPressed()) m_bfButtons.apply(BM_A_PRESSED); */
            /* if (BaseInput.isLAReleased()) m_bfButtons.apply(BM_A_RELEASED); */
            /* if (BaseInput.isLBPressed()) m_bfButtons.apply(BM_B_PRESSED); */
            /* if (BaseInput.isLBReleased()) m_bfButtons.apply(BM_B_RELEASED); */
            /* if (BaseInput.isLXPressed()) m_bfButtons.apply(BM_X_PRESSED); */
            /* if (BaseInput.isLXReleased()) m_bfButtons.apply(BM_X_RELEASED); */
            /* if (BaseInput.isLYPressed()) m_bfButtons.apply(BM_Y_PRESSED); */
            /* if (BaseInput.isLYReleased()) m_bfButtons.apply(BM_Y_RELEASED); */
            if (BaseInput.isTriggerPressed()) m_bfButtons.apply(BM_TRIGGER_PRESSED);
            if (BaseInput.isTriggerReleased())
                m_bfButtons.apply(BM_TRIGGER_RELEASED);
            if (BaseInput.isGripPressed()) m_bfButtons.apply(BM_GRIP_PRESSED);
            if (BaseInput.isGripReleased()) m_bfButtons.apply(BM_GRIP_RELEASED);
            if (BaseInput.isAPressed()) m_bfButtons.apply(BM_A_PRESSED);
            if (BaseInput.isAReleased()) m_bfButtons.apply(BM_A_RELEASED);
            if (BaseInput.isBPressed()) m_bfButtons.apply(BM_B_PRESSED);
            if (BaseInput.isBReleased()) m_bfButtons.apply(BM_B_RELEASED);
            if (BaseInput.isXPressed()) m_bfButtons.apply(BM_X_PRESSED);
            if (BaseInput.isXReleased()) m_bfButtons.apply(BM_X_RELEASED);
            if (BaseInput.isYPressed()) m_bfButtons.apply(BM_Y_PRESSED);
            if (BaseInput.isYReleased()) m_bfButtons.apply(BM_Y_RELEASED);
            break;

        case Constants.RIGHT:
            if (BaseInput.isRTriggerPressed()) m_bfButtons.apply(BM_TRIGGER_PRESSED);
            if (BaseInput.isRTriggerReleased())
                m_bfButtons.apply(BM_TRIGGER_RELEASED);
            if (BaseInput.isRGripPressed()) m_bfButtons.apply(BM_GRIP_PRESSED);
            if (BaseInput.isRGripReleased()) m_bfButtons.apply(BM_GRIP_RELEASED);
            if (BaseInput.isRAPressed()) m_bfButtons.apply(BM_A_PRESSED);
            if (BaseInput.isRAReleased()) m_bfButtons.apply(BM_A_RELEASED);
            if (BaseInput.isRBPressed()) m_bfButtons.apply(BM_B_PRESSED);
            if (BaseInput.isRBReleased()) m_bfButtons.apply(BM_B_RELEASED);
            if (BaseInput.isRXPressed()) m_bfButtons.apply(BM_X_PRESSED);
            if (BaseInput.isRXReleased()) m_bfButtons.apply(BM_X_RELEASED);
            if (BaseInput.isRYPressed()) m_bfButtons.apply(BM_Y_PRESSED);
            if (BaseInput.isRYReleased()) m_bfButtons.apply(BM_Y_RELEASED);
            break;

        // do not update any arbitrary bitfields
        // if no controller hand is set
        default:
            break;
        }
    }

    /**
     * Determines which hand (left or right) this controller represents.
     */

    public string getHand() { return m_sHand; }
    public void   setHand(string hand) { m_sHand = hand; }

    /**
     * Unity method
     * Called on each update frame
     */

    void Update() {
        if (m_bfButtons.has(BM_TRIGGER_PRESSED)) {
            Debug.Log("trigger was pressed");
        }
        if (m_bfButtons.has(BM_TRIGGER_RELEASED)) {
            Debug.Log("trigger was released");
        }

        // reset bitfield for next update
        m_bfButtons.reset();

        BaseUpdate();
    }
}
