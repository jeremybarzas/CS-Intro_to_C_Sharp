using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WinForms_Combat_Assessment
{
    public partial class DiceRoll : Form
    {
        public DiceRoll()
        {
            InitializeComponent();
        }

        private void DiceRoll_Load(object sender, EventArgs e)
        {
            Next.Enabled = false;
        }

        private void Roll_Click(object sender, EventArgs e)
        {
            GameManager.Instance.DataManager.AssignTurnOrder();

            for (int i = 0, j = 1; i < GameManager.Instance.DataManager.GameRoster.Count; i++, j++)
            {
                Turn_Order_Box.Text += j + ": " + GameManager.Instance.DataManager.GameRoster[i].Name + "\n\n";
            }

            Roll.Enabled = false;
            Next.Enabled = true;
        }

        private void Next_Click(object sender, EventArgs e)
        {
            GameManager.Instance.DataManager.SetCurrentPlayer();

            GameManager.Instance.DataManager.FSM.SetState(5);
            Form nextForm = Program.ChangeForm(GameManager.Instance.DataManager.FSM);
            this.Dispose();
            nextForm.Show();
        }

        private void To_Main_Menu_Click(object sender, EventArgs e)
        {
            GameManager.Instance.DataManager.FSM.SetState(0);
            Form nextForm = Program.ChangeForm(GameManager.Instance.DataManager.FSM);
            this.Dispose();
            nextForm.Show();
        }
    }
}