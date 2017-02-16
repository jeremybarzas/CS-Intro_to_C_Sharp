using System;

namespace WinForms_Combat_Assessment
{
    public class Ether : IPackable, IUseable
    {
        private int m_manaPower;
        public string Name { get; set; }

        public Ether() { }

        public Ether(int mana)
        {
            Name = "Ether";
            m_manaPower = mana;
        }

        public void Use(Character target)
        {
            target.Mana += m_manaPower;
        }
    }
}