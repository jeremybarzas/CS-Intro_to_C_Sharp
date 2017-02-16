using System;

namespace WinForms_Combat_Assessment
{
    public class Potion : IPackable, IUseable
    {
        private int m_healingPower;
        public string Name { get; set; }

        public Potion() { }

        public Potion(int heal)
        {
            Name = "Potion";
            m_healingPower = heal;
        }

        public void Use(Character target)
        {
            target.Health += m_healingPower;
        }
    }
}