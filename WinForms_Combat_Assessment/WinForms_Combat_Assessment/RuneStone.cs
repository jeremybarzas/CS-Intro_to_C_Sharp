using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_Combat_Assessment
{
    class RuneStone : IPackable, IConsumable
    {
        private string m_name;
        private int strBuff;
        private int intBuff;

        public string Name
        {
            get { return m_name; }
        }

        public RuneStone()
        { }

        public RuneStone(string n, int s, int i)
        {
            m_name = n;
            strBuff = s;
            intBuff = i;
        }

        public void Consume(Character target)
        {
            target.Strength += strBuff;
            target.Intellect += intBuff;
        }
    }
}