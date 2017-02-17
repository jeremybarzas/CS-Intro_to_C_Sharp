namespace WinForms_Combat_Assessment
{
    public class Blizzard : Spell
    {
        public override void Cast(Character target, int intModifer)
        {
            target.Health -= SpellPower * intModifer;
        }

        public Blizzard(string n, int dmg, int mana)
        {
            Name = n;
            SpellPower = dmg;
            ManaCost = mana;
        }      
    }
}