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
    public partial class Scoreboard : Form
    {
        public Scoreboard()
        {
            InitializeComponent();
        }

        private void Scoreboard_Load(object sender, EventArgs e)
        {
            Scoreboard_Text.Text = GameManager.Instance.GameRoster[0].Name + "\n" + GameManager.Instance.GameRoster[1].Name + "\n" + GameManager.Instance.GameRoster[2].Name + "\n";
        }

        private void To_Main_Menu_Click(object sender, EventArgs e)
        {
            GameManager.Instance.FSM_GAMESTATE.SetState(0);
            Form nextForm = Program.ChangeForm(GameManager.Instance.FSM_GAMESTATE);
            this.Hide();
            nextForm.Show();
        }

        private void Start_Game_Click(object sender, EventArgs e)
        {
            GameManager.Instance.FSM_GAMESTATE.SetState(4);
            Form nextForm = Program.ChangeForm(GameManager.Instance.FSM_GAMESTATE);
            this.Hide();
            nextForm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Scoreboard_Text_TextChanged(object sender, EventArgs e)
        {

        }
    }
}