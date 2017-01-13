using System;
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
}