using System;

namespace WinForms_Combat_Assessment
{
    public class Potion : IPackable, IConsumable
    {
        private int m_healingPower;
        public string Name { get; set; }

        public Potion() { }

        public Potion(int heal)
        {
            Name = "Potion";
            m_healingPower = heal;
        }

        public void Consume(Character target)
        {
            target.Health += m_healingPower;
        }
    }
}