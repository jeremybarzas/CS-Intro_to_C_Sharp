using System;
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
            FormManager.Instance.DataManager.GameRoster.Sort((a, b) => -1 * (a.Info.Gold.CompareTo(b.Info.Gold)));

            foreach (Character character in FormManager.Instance.DataManager.GameRoster)
            {
                Player_Name_Text.Text += " " + character.Info.Name + "\n\n";                
                Kills_Text.Text += "    " + character.Info.Kills + "\n\n";
                Score_Text.Text += "    " + character.Info.Gold + "\n\n";

                if (character.Info.Alive == true)
                    Status_Text.Text += "   Alive" + "\n\n";
                else
                    Status_Text.Text += "   Dead" + "\n\n";          
            }
        }

        private void To_Main_Menu_Click(object sender, EventArgs e)
        {
            Program.ChangeForm(this, 0);
        }

        private void Start_Game_Click(object sender, EventArgs e)
        {
            Program.ChangeForm(this, 4);
        }

        private void Save_Game_Click(object sender, EventArgs e)
        {           
            DataSerializer<DataManager>.Serialize("GameSave", FormManager.Instance.DataManager);
        }
    }
}