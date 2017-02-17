namespace WinForms_Combat_Assessment
{
    public class Potion : Item
    {
        private int m_healingPower;
        private int m_manaPower;

        public override void Use(Character target)
        {
            target.Info.Health += m_healingPower;
            target.Info.Mana += m_manaPower;
        }

        public Potion() { }

        public Potion(string n, int heal, int mana)
        {
            Name = n;
            m_healingPower = heal;
            m_manaPower = mana;
        }      
    }
}