using System;
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
            for (int i = 2; i <= 15; i++)
                Number_of_Players_Selector.Items.Add(i);

            foreach (var control in Controls)
            {
                var c = control as ComboBox;
                if (c != null)
                    c.SelectedIndex = 0;
            }

            Game_Rules_Text.Text = "Even though you can click this box and make a cursor appear you cannot type in this box because it is set to readonly.\n\nThis is the rules of the game.";
        }

        private void To_Main_Menu_Click(object sender, EventArgs e)
        {
            Program.ChangeForm(this, 0);
        }

        private void Next_Click(object sender, EventArgs e)
        {
            Program.ChangeForm(this, 2);
        }

        private void Number_of_Players_Selector_SelectedIndexChanged(object sender, EventArgs e)
        {
            AppManager.Instance.DataManager.PlayerCount = (int)Number_of_Players_Selector.SelectedItem;          
        }
    }
}