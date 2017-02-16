using System;

namespace WinForms_Combat_Assessment
{
    public class RuneStone : IPackable, IUseable
    {
        private int strBuff;
        private int intBuff;
        public string Name { get; set; }

        public RuneStone() { }

        public RuneStone(int s, int i)
        {
            Name = "Runestone";
            strBuff = s;
            intBuff = i;
        }

        public void Use(Character target)
        {
            target.Strength += strBuff;
            target.Intellect += intBuff;
        }
    }
}