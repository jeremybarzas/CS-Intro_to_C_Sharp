using System.Windows.Forms;

namespace ButtonsLecture
{
    public class Player
    {
        private string name;
        private int totalExp;
        private int curExp;
        private int reqExp;
        private int level;

        public string Name
        {
            get { return name; }

            set { name = value; }
        }

        public int TotalExp
        {
            get { return totalExp; }

            set { totalExp = value; }
        }

        public int CurExp
        {
            get { return curExp; }

            set { curExp = value; }
        }

        public int ReqExp
        {
            get { return reqExp; }

            set { reqExp = value; }
        }

        public int Level
        {
            get { return level; }

            set { level = value; }
        }

        public Player()
        {
            name = "Default Player";
            totalExp = 0;
            curExp = 0;
            reqExp = 100;
            level = 1;
        }

        public Player(string n)
        {
            name = n;
            totalExp = 0;
            curExp = 0;
            reqExp = 100;
            level = 1;
        }

        public void ExpAdd(int xp)
        {
            totalExp += xp;
            curExp += xp;

            if (curExp > reqExp)
            {
                LevelUp();
            }
        }

        public void LevelUp()
        {
            level++;
            curExp = curExp - reqExp;
            reqExp *= 2;

            MessageBox.Show("You Have Leveled Up!!!", "CONGRATULATIONS", MessageBoxButtons.OK);
        }
    }
}