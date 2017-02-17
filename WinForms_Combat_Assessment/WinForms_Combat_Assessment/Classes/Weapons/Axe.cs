namespace WinForms_Combat_Assessment
{
    public class Axe : Weapon
    {
        new public void Strike(Character target, int strModifer)
        {
            target.Health -= Damage * strModifer;
        }

        public Axe() { }

        public Axe(string n, int dmg)
        {
            Name = n;
            Damage = dmg;
        }        
    }
}