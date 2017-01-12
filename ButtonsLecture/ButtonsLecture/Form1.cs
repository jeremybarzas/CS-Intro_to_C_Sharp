using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButtonsLecture
{
    public partial class Form1 : Form
    {
        public delegate void DoStuff(int i);

        public Player player;

        public DoStuff dostuff;

        public Form1()
        {
            player = new Player("Bob");
            dostuff += UpdateState;
            InitializeComponent();
        }

        public void UpdateState(int i)
        {
            player.ExpAdd(i);

            float slice = (float)player.CurExp / (float)player.ReqExp * 100;
            progressBar1.Value = (int)slice;

            textBox1.Text = player.Name + " is level " + player.Level;
            textBox2.Text = player.Name + "'s current Exp is " + player.CurExp;
            textBox3.Text = player.Name + "'s required Exp is " + player.ReqExp;
            textBox4.Text = "Progress %: " + progressBar1.Value;
            textBox5.Text = player.Name + "'s total Exp is " + player.TotalExp;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = player.Name + " is level " + player.Level;
            textBox2.Text = player.Name + "'s current Exp is " + player.CurExp;
            textBox3.Text = player.Name + "'s required Exp is " + player.ReqExp;
            textBox4.Text = "Progress %: " + progressBar1.Value;
            textBox5.Text = player.Name + "'s total Exp is " + player.TotalExp;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dostuff.Invoke(10);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dostuff.Invoke(50);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dostuff.Invoke(100);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
 
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

            if (curExp >= reqExp)
            {
                LevelUp();
            }
        }

        public void ExpAdd10()
        {
            totalExp += 10;
            curExp += 10;

            if (curExp >= reqExp)
            {
                LevelUp();
            }
        }

        public void ExpAdd50()
        {
            totalExp += 50;
            curExp += 50;

            if (curExp >= reqExp)
            {
                LevelUp();
            }
        }

        public void ExpAdd100()
        {
            totalExp += 100;
            curExp += 100;
            
            if (curExp >= reqExp)
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