using System;
using System.Windows.Forms;

namespace WinForms_Combat_Assessment
{
    public partial class GameOver : Form
    {
        public GameOver()
        {
            InitializeComponent();
        }

        private void GameOver_Load(object sender, EventArgs e)
        {
            AppManager.Instance.DataManager.GameRoster.Sort((a, b) => -1 * (a.Info.Alive.CompareTo(b.Info.Alive)));

            foreach (Character character in AppManager.Instance.DataManager.GameRoster)
            {
                Player_Name_Text.Text += " " + character.Info.Name + "\n\n";
                Kills_Text.Text += "    " + character.Info.Kills + "\n\n";
                Damage_Dealt_Text.Text += "    " + character.Info.DamageDealt + "\n\n";

                if (character.Info.Alive == true)
                {
                    Status_Text.Text += "   Alive" + "\n\n";
                    Game_Winner_Label.Text = character.Info.Name + " has won the game.";
                }
                
                else
                    Status_Text.Text += "   Dead" + "\n\n";
            }
        }

        private void To_Main_Menu_Click(object sender, EventArgs e)
        {
            Program.ChangeForm(this, 0);
        }

        private void Exit_Game_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}