using System;
using System.Windows.Forms;

namespace WinForms_Combat_Assessment
{
    public partial class CharacterSheet : Form
    {
        public CharacterSheet()
        {                        
            InitializeComponent();
        }

        private void CharacterSheet_Load(object sender, EventArgs e)
        {

        }

        private void To_Main_Menu_Click(object sender, EventArgs e)
        {
            Program.ChangeForm(0);
        }

        private void Next_Click(object sender, EventArgs e)
        {
            // Actual Code
            FormManager.Instance.DataManager.AddToRoster(new Character(Character_Name.Text));

            if (FormManager.Instance.DataManager.GameRoster.Count < FormManager.Instance.DataManager.PlayerCount)
                Program.ChangeForm(this, 2);
            else
                Program.ChangeForm(this, 3);

            //// Test Code
            //FormManager.Instance.DataManager.AddToRoster(new Character("Test Player 1"));
            //FormManager.Instance.DataManager.AddToRoster(new Character("Test Player 2"));
            //FormManager.Instance.DataManager.AddToRoster(new Character("Test Player 3"));
            //FormManager.Instance.DataManager.AddToRoster(new Character("Test Player 4"));
            //FormManager.Instance.DataManager.AddToRoster(new Character("Test Player 5"));
            //FormManager.Instance.DataManager.AddToRoster(new Character("Test Player 6"));
            //FormManager.Instance.DataManager.AddToRoster(new Character("Test Player 7"));
            //FormManager.Instance.DataManager.AddToRoster(new Character("Test Player 8"));
            //FormManager.Instance.DataManager.AddToRoster(new Character("Test Player 9"));
            //FormManager.Instance.DataManager.AddToRoster(new Character("Test Player 10"));

            //Program.ChangeForm(this, 3);
        }
    }    
}