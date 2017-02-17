namespace WinForms_Combat_Assessment
{
    public class Mace : Weapon
    {
        new public void Strike(Character target, int strModifer)
        {
            target.Health -= Damage * strModifer;
        }

        public Mace() { }

        public Mace(string n, int dmg)
        {
            Name = n;
            Damage = dmg;
        }
    }
}