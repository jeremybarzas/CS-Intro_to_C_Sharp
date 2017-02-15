using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace WinForms_Combat_Assessment.Classes.Spells
{
    class DivineIntervention
    {
        private string m_name;
        private int m_healing;
        private int m_manaCost;

        public DivineIntervention(int heal, int mana)
        {
            m_name = "DivineIntervention";
            m_healing = heal;
            m_manaCost = mana;
        }

        public bool Cast(Character target, int Int)
        {
            if (target.Mana >= m_manaCost)
            {
                target.Health += (m_healing * Int);
                return true;
            }
            else
            {
                Debug.WriteLine("Not enough mana!!!\n");
                return false;
            }
        }
    }
}
