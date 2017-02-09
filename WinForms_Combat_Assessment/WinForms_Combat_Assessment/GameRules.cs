using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_Combat_Assessment
{
    public partial class GameRules : Form
    {
        public GameRules()
        {
            InitializeComponent();
            
            comboBox1.Items.Add(2);
            comboBox1.Items.Add(3);
            comboBox1.Items.Add(4);
            comboBox1.Items.Add(5);
            comboBox1.Items.Add(6);
            comboBox1.Items.Add(7);
            comboBox1.Items.Add(8);
            comboBox1.Items.Add(9);
            comboBox1.Items.Add(10);
        }

        private void To_Main_Menu_Click(object sender, EventArgs e)
        {
            GameManager.Instance.FSM_GAMESTATE.SetState(0);
            Form nextForm = Program.ChangeForm(GameManager.Instance.FSM_GAMESTATE);
            this.Hide();
            nextForm.Show();
        }

        private void Next_Click(object sender, EventArgs e)
        {
            GameManager.Instance.FSM_GAMESTATE.SetState(2);
            Form nextForm = Program.ChangeForm(GameManager.Instance.FSM_GAMESTATE);
            this.Hide();
            nextForm.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GameManager.Instance.PlayerCount = (int)comboBox1.SelectedItem;          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}