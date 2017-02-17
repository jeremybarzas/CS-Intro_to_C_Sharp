namespace WinForms_Combat_Assessment
{
    public class Mace : Weapon
    {
        public override void Strike(Character target, int strModifer)
        {
            target.Info.Health -= Damage * strModifer;
        }

        public Mace() { }

        public Mace(string n, int dmg)
        {
            Name = n;
            Damage = dmg;
        }
    }
}