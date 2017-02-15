using System;

namespace WinForms_Combat_Assessment
{
    public class Elixir: IPackable, IConsumable
    {
        private int m_healingPower;
        private int m_manaPower;
        public string Name { get; set; }

        public Elixir() { }

        public Elixir(int heal, int mana)
        {
            Name = "Elixir";
            m_healingPower = heal;
            m_manaPower = mana;
        }

        public void Consume(Character target)
        {           
            target.Health += m_healingPower;
            target.Mana += m_manaPower;
        }
    }
}