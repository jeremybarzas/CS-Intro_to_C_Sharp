﻿namespace WinForms_Combat_Assessment
{
    public class DivineIntervention : Spell
    {
        public override void Cast(Character target, int intModifer)
        {
            int dmg = (SpellPower * intModifer);
            target.Info.Health -= dmg;
        }

        public DivineIntervention() { }

        public DivineIntervention(string n, int dmg, int mana)
        {
            Name = n;
            SpellPower = dmg;
            ManaCost = mana;
        }
    }
}