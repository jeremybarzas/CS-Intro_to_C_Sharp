using System.Collections.Generic;

namespace WinForms_Combat_Assessment
{
    public class DivineIntervention : Spell
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

        public DivineIntervention() { }

        public DivineIntervention(string n, int dmg, int heal, int mana)
        {
            Name = n;
            Damage = dmg;
            Healing = heal;
            ManaCost = mana;
        }
    }
}