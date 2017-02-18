namespace WinForms_Combat_Assessment
{
    public class Mace : Weapon
    {
        public override void Strike(Character target, int strModifer)
        {
            int dmg = (Damage * strModifer);
            target.Info.Health -= Damage;
        }

        public Mace() { }

        public Mace(string n, int dmg)
        {
            Name = n;
            Damage = dmg;
        }
    }
}