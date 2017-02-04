using System;
using System.Collections.Generic;

namespace WinForms_Combat_Assessment
{
    public class RuneStone : IPackable, IConsumable
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