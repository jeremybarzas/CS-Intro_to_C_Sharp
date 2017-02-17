namespace WinForms_Combat_Assessment
{
    public class LightningBolt : Spell
    {
        public override void Cast(Character target, int intModifer)
        {
            target.Info.Health -= SpellPower * intModifer;
        }

        public LightningBolt() { }

        public LightningBolt(string n, int dmg, int mana)
        {
            Name = n;
            SpellPower = dmg;
            ManaCost = mana;
        }
    }
}