namespace WinForms_Combat_Assessment
{
    public class Axe : Weapon
    {
        public override void Strike(Character target, int strModifer)
        {
            int dmg = (Damage * strModifer);
            target.Info.Health -= Damage;
        }

        public Axe() { }

        public Axe(string n, int dmg)
        {
            Name = n;
            Damage = dmg;
        }        
    }
}