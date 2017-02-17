namespace WinForms_Combat_Assessment
{
    public class Axe : Weapon
    {
        public override void Strike(Character target, int strModifer)
        {
            target.Info.Health -= Damage * strModifer;
        }

        public Axe() { }

        public Axe(string n, int dmg)
        {
            Name = n;
            Damage = dmg;
        }        
    }
}