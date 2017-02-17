namespace WinForms_Combat_Assessment
{
    public class Flashburn : Spell
    {
        public override void Cast(Character target, int intModifer)
        {
            target.Health -= SpellPower * intModifer;
        }
        
        public Flashburn(string n, int dmg, int mana)
        {
            Name = n;
            SpellPower = dmg;
            ManaCost = mana;
        }
    }
}