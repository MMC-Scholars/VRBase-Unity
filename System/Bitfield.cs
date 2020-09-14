/**
 * A bitfield is an integer value which holds flags in each bit.
 * Each flag corresponds to a unique boolean value.
 */

public class Bitfield {
    private ulong m_bf;
    public Bitfield() { m_bf = 0; }

    /**
     * Static method to generate an unsigned numerical value bit shifted
     * [shift] units, or a bitmask.
     */
    public static ulong mask(int shift) { return ((ulong) 1) << shift; }

    /**
     * Applies a bitmask [mask] to the bitfield.
     */
    public void apply(ulong mask) { m_bf |= mask; }

    /**
     * Returns true if the bitfield has the
     * bitmask (flag) [mask] enabled.
     */
    public bool has(ulong mask) { return m_bf == (m_bf | mask); }

    /**
     * Removes a bitmask [mask] from the bitfield.
     */
    public void remove(ulong mask) { m_bf &= ~mask; }
}
