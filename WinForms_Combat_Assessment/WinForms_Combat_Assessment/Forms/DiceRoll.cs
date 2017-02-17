using System;
using System.Windows.Forms;

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
            FormManager.Instance.DataManager.AssignTurnOrder();

            for (int i = 0, j = 1; i < FormManager.Instance.DataManager.GameRoster.Count; i++, j++)
            {
                Turn_Order_Box.Text += j + ": " + FormManager.Instance.DataManager.GameRoster[i].Info.Name + "\n\n";
            }

            Roll.Enabled = false;
            Next.Enabled = true;
        }

        private void Next_Click(object sender, EventArgs e)
        {
            FormManager.Instance.DataManager.SetCurrentPlayer();

            Program.ChangeForm(this, 5);
        }

        private void To_Main_Menu_Click(object sender, EventArgs e)
        {
            Program.ChangeForm(this, 0);
        }
    }
}