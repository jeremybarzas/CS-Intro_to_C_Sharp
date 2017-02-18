namespace WinForms_Combat_Assessment
{
    public class Flashburn : Spell
    {
        public override void Cast(Character target, int intModifer)
        {
            int dmg = (SpellPower * intModifer);
            target.Info.Health -= dmg;
        }

        public Flashburn() { }

        public Flashburn(string n, int dmg, int mana)
        {
            Name = n;
            SpellPower = dmg;
            ManaCost = mana;
        }
    }
}