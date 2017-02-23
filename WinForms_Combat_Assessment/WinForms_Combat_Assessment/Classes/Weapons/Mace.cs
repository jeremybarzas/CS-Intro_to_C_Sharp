namespace WinForms_Combat_Assessment
{
    public class Mace : Weapon
    {
        public override int Strike(Character target, int strModifer)
        {
            int dmg = (Damage * strModifer);
            target.Info.Health -= dmg;
            return dmg;
        }

        public Mace() { }

        public Mace(string n, int dmg)
        {
            Name = n;
            Damage = dmg;
            WeaponInfo += Name + ": - " + Damage + " Health";
        }
    }
}