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
            //// Actual Code
            GameManager.Instance.DataManager.AddToRoster(new Character(Character_Name.Text));

            if (GameManager.Instance.DataManager.GameRoster.Count < GameManager.Instance.DataManager.PlayerCount)
                Program.ChangeForm(this, 2);
            else
                Program.ChangeForm(this, 3);

            //// Test Code
            //GameManager.Instance.AddToRoster(new Character("Test Player 1"));
            //GameManager.Instance.AddToRoster(new Character("Test Player 2"));
            //GameManager.Instance.AddToRoster(new Character("Test Player 3"));
            //GameManager.Instance.AddToRoster(new Character("Test Player 4"));
            //GameManager.Instance.AddToRoster(new Character("Test Player 5"));
            //GameManager.Instance.AddToRoster(new Character("Test Player 6"));
            //GameManager.Instance.AddToRoster(new Character("Test Player 7"));
            //GameManager.Instance.AddToRoster(new Character("Test Player 8"));
            //GameManager.Instance.AddToRoster(new Character("Test Player 9"));
            //GameManager.Instance.AddToRoster(new Character("Test Player 10"));

            //Program.ChangeForm(3);
        }
    }    
}