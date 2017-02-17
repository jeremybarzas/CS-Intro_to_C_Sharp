namespace WinForms_Combat_Assessment
{
    public class RuneStone : Item
    {
        private int strBuff;
        private int intBuff;

        new public void Use(Character target)
        {
            target.Strength += strBuff;
            target.Intellect += intBuff;
        }

        public RuneStone() { }

        public RuneStone(string n, int s, int i)
        {
            Name = n;
            strBuff = s;
            intBuff = i;
        }       
    }
}