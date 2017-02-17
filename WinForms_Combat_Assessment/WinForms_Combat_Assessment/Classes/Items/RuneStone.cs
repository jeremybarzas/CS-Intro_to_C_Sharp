namespace WinForms_Combat_Assessment
{
    public class RuneStone : Item
    {
        private int m_strBuff;
        private int m_intBuff;

        public override void Use(Character target)
        {
            target.Info.Strength += m_strBuff;
            target.Info.Intellect += m_intBuff;
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