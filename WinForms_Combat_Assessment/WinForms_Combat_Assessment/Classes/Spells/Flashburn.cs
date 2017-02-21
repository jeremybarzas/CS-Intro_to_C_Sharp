using System.Collections.Generic;

namespace WinForms_Combat_Assessment
{
    public class Flashburn : Spell
    {
        public override List<int> Cast(Character target, int intModifer)
        {
            List<int> values = new List<int>();

            int dmg = (Damage * intModifer);
            int heal = (Healing * intModifer);

            target.Info.Health -= dmg;
            target.Info.Health += heal;

            values.Add(dmg);
            values.Add(heal);

            return values;
        }

        public Flashburn() { }

        public Flashburn(string n, int dmg, int heal, int mana)
        {
            Name = n;
            Damage = dmg;
            Healing = heal;
            ManaCost = mana;
        }
    }
}