namespace BridgePattern
{
    public abstract class IWeapon
    {
        public string Name { get;  protected set; }

        public abstract void Wield();
        public abstract void Swing();
        public abstract void Unwield();
        public abstract IEnchantment GetEnhancement();
    }
}