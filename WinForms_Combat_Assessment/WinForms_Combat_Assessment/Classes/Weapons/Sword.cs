namespace WinForms_Combat_Assessment
{
    public class Sword : Weapon
    {
        public override void Strike(Character target, int strModifer)
        {
            target.Info.Health -= Damage * strModifer;
        }

        public Sword() { }

        public Sword(string n, int dmg)
        {
            Name = n;
            Damage = dmg;
        }
    }
}