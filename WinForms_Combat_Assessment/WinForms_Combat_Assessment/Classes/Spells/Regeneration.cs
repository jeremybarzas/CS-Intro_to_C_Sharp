namespace WinForms_Combat_Assessment
{
    public class Regeneration : Spell
    {
        public override void Cast(Character target, int intModifer)
        {
            target.Info.Health -= SpellPower * intModifer;
        }

        public Regeneration() { }

        public Regeneration(string n, int dmg, int mana)
        {
            Name = n;
            SpellPower = dmg;
            ManaCost = mana;
        }
    }
}