using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace WinForms_Combat_Assessment.Classes.Spells
{
    class LightningBolt : ICastable
    {
        private string m_name;
        private int m_damage;
        private int m_manaCost;

        public LightningBolt(int dmg, int mana)
        {
            m_name = "LightningBolt";
            m_damage = dmg;
            m_manaCost = mana;
        }

        public void Cast(Character target, int Int)
        {
            target.Health -= (m_damage * Int);
        }
    }
}