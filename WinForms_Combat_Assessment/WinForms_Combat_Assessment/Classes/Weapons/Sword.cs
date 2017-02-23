namespace WinForms_Combat_Assessment
{
    public class Sword : Weapon
    {
        public override int Strike(Character target, int strModifer)
        {
            int dmg = (Damage * strModifer);
            target.Info.Health -= dmg;
            return dmg;
        }
        
        public Sword() { }

        public Sword(string n, int dmg)
        {
            Name = n;
            Damage = dmg;
            WeaponInfo += Name + ": - " + Damage + " Health";
        }
    }
}