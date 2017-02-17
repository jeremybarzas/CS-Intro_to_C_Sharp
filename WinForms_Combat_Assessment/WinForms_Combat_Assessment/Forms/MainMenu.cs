using System;
using System.Windows.Forms;

namespace WinForms_Combat_Assessment
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void New_Game_Click(object sender, EventArgs e)
        {
            Program.ChangeForm(this, 1);
        }

        private void Load_Game_Click(object sender, EventArgs e)
        {            
            FormManager.Instance.DataManager = DataSerializer<DataManager>.Deserialize("GameSave");

            Program.ChangeForm(this, 3);
        }

        private void Exit_Game_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Game_Title_Click(object sender, EventArgs e)
        {

        }

        private void Form_Name_Click(object sender, EventArgs e)
        {

        }
    }
}