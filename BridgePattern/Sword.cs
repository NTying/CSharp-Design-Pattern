namespace BridgePattern
{
    public class Sword : IWeapon
    {
        private readonly IEnchantment _enchantment;

        public Sword(IEnchantment enchantment)
        {
            _enchantment = enchantment;
        }

        public override IEnchantment GetEnhancement()
        {
            return _enchantment;
        }

        public override void Swing()
        {
            Console.WriteLine("The sword is swinged");
            _enchantment.Apply();
        }

        public override void Unwield()
        {
            Console.WriteLine("The sword is unwielded");
            _enchantment.OnDeactivate();
        }

        public override void Wield()
        {
            Console.WriteLine("The sword is wielded");
            _enchantment.OnActivate();
        }
    }
}
