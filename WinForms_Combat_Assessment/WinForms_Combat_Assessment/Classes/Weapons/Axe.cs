using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_Combat_Assessment.Classes.Weapons
{
    class Axe
    {
        private string m_name;
        private int m_damage;

        public Axe(int dmg)
        {
            m_name = "Axe";
            m_damage = dmg;
        }

        public void Swing(Character target, int Str)
        {
            target.Health -= (m_damage * Str);
        }
    }
}
