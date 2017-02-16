using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace WinForms_Combat_Assessment.Classes.Spells
{
    class Regeneration : ICastable
    {
        private string m_name;
        private int m_healing;
        private int m_manaCost;

        public Regeneration(int heal, int mana)
        {
            m_name = "Regeneration";
            m_healing = heal;
            m_manaCost = mana;
        }

        public void Cast(Character target, int Int)
        {
            target.Health += (m_healing * Int);
        }
    }
}