using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WinForms_Combat_Assessment
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void got_to_rules_Click(object sender, EventArgs e)
        {
            GameManager.Instance.FSM_GAMESTATE.SetState(1);
            Form nextForm = Program.ChangeForm(GameManager.Instance.FSM_GAMESTATE);
            this.Hide();
            nextForm.Show();            
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }
    }
}