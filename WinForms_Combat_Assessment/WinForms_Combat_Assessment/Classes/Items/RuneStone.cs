using System.Collections.Generic;

namespace WinForms_Combat_Assessment
{
    public class RuneStone : Item
    {
        public int m_strBuff;
        public int m_intBuff;

        public override List<int> Use(Character target)
        {
            List<int> values = new List<int>();

            target.Info.Strength += m_strBuff;
            target.Info.Intellect += m_intBuff;

            values.Add(0);
            values.Add(0);
            values.Add(m_strBuff);
            values.Add(m_intBuff);           

            return values;
        }

        public RuneStone() { }

        public RuneStone(string n, int s, int i)
        {
            Name = n;
            m_strBuff = s;
            m_intBuff = i;
        }       
    }
}