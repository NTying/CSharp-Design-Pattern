using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    public class Sword : IWeapon
    {
        private readonly IEnchantment _enhancement;

        public Sword(IEnchantment enhancement)
        {
            _enhancement = enhancement;
        }

        public override IEnchantment GetEnhancement()
        {
            return _enhancement;
        }

        public override void Swing()
        {
            Console.WriteLine("The sword is swinged");
            _enhancement.Apply();
        }

        public override void Unwield()
        {
            Console.WriteLine("The sword is unwielded");
            _enhancement.OnDeactivate();
        }

        public override void Wield()
        {
            Console.WriteLine("The sword is wielded");
            _enhancement.OnActivate();
        }
    }
}
