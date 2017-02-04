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
            //GameManager.Instance.FSM_GAMESTATE.SetState(new GameRulesState());
            GameManager.Instance.IncrementScore();
            Button b = sender as Button;
            b.Text = GameManager.Instance.score.ToString();
            Visible = false;
        }
    }
}