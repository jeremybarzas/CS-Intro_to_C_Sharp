using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_Combat_Assessment
{
    class Stats
    {
        private int m_health;
        private int m_mana;
        private int m_maxHealth;
        private int m_maxMana;
        private int m_strength;
        private int m_intellect;

        public int Health
        {
            get { return m_health; }
            set { m_health = value; }
        }

        public int Mana
        {
            get { return m_mana; }
            set { m_mana = value; }
        }

        public int MaxHealth
        {
            get { return m_maxHealth; }
            set { m_maxHealth = value; }
        }

        public int MaxMana
        {
            get { return m_maxMana; }
            set { m_maxMana = value; }
        }

        public int Strength
        {
            get { return m_strength; }
            set { m_strength = value; }
        }

        public int Intellect
        {
            get { return m_intellect; }
            set { m_intellect = value; }
        }

        public Stats() { }

    }
}