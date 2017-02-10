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
        }

        private void GameRules_Load(object sender, EventArgs e)
        {
            for (int i = 2; i <= 100; i++)
                comboBox1.Items.Add(i);
        }

        private void To_Main_Menu_Click(object sender, EventArgs e)
        {
            GameManager.Instance.FSM.SetState(0);
            Form nextForm = Program.ChangeForm(GameManager.Instance.FSM);
            this.Dispose();
            nextForm.Show();
        }

        private void Next_Click(object sender, EventArgs e)
        {
            GameManager.Instance.FSM.SetState(2);
            Form nextForm = Program.ChangeForm(GameManager.Instance.FSM);
            this.Dispose();
            nextForm.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GameManager.Instance.PlayerCount = (int)comboBox1.SelectedItem;          
        }
    }
}