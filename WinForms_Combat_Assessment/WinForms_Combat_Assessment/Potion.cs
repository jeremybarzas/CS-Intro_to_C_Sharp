using System;

namespace WinForms_Combat_Assessment
{
    public class Potion : IPackable, IConsumable
    {
        private string m_name;
        private int m_healingPower;
        private int m_manaPower;

        public string Name
        {
            get { return m_name; }
        }

        public Potion() { }

        public Potion(string n, int heal, int mana)
        {
            m_name = n;
            m_healingPower = heal;
            m_manaPower = mana;
        }

        public void Consume(Character target)
        {
            bool healthfull = target.Health == target.MaxHealth;
            bool manafull = target.Mana == target.MaxMana;

            if (!healthfull)
                target.Health += m_healingPower;

            if (!manafull)
                target.Mana += m_manaPower;       
        }
    }
}