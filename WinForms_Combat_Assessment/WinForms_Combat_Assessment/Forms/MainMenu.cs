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

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void New_Game_Click(object sender, EventArgs e)
        {
            GameManager.Instance.DataManager.FSM.SetState(1);
            Form nextForm = Program.ChangeForm(GameManager.Instance.DataManager.FSM);
            this.Enabled = false;
            this.Visible = false;
            nextForm.Show();
        }

        private void Load_Game_Click(object sender, EventArgs e)
        {
            //DataManager dm = GameSerialization<DataManager>.Deserialize("GameSave");
            GameManager.Instance.DataManager = GameSerialization<DataManager>.Deserialize("GameSave");;

            GameManager.Instance.DataManager.FSM.SetState(3);
            Form nextForm = Program.ChangeForm(GameManager.Instance.DataManager.FSM);
            this.Enabled = false;
            this.Visible = false;
            nextForm.Show();          
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