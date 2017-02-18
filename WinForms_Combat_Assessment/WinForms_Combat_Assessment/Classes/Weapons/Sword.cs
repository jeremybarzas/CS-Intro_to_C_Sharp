namespace WinForms_Combat_Assessment
{
    public class Sword : Weapon
    {
        public override void Strike(Character target, int strModifer)
        {
            int dmg = (Damage * strModifer);
            target.Info.Health -= Damage;
        }

        public Sword() { }

        public Sword(string n, int dmg)
        {
            Name = n;
            Damage = dmg;
        }
    }
}