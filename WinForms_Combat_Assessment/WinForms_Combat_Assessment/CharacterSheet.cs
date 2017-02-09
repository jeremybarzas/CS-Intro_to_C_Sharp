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
    public partial class CharacterSheet : Form
    {
        public Character newCharacter;

        public CharacterSheet()
        {
            InitializeComponent();
        }

        private void CharacterSheet_Load(object sender, EventArgs e)
        {

        }

        private void Character_Name_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void To_Main_Menu_Click(object sender, EventArgs e)
        {
            GameManager.Instance.FSM_GAMESTATE.SetState(0);
            Form nextForm = Program.ChangeForm(GameManager.Instance.FSM_GAMESTATE);
            this.Hide();
            nextForm.Show();
        }

        private void Next_Click(object sender, EventArgs e)
        {
            // Actual Code

            //GameManager.Instance.AddToRoster(new Character(Character_Name.Text));

            //if (GameManager.Instance.GameRoster.Count < GameManager.Instance.PlayerCount)
            //{
            //    GameManager.Instance.FSM_GAMESTATE.SetState(2);
            //    Form nextForm = Program.ChangeForm(GameManager.Instance.FSM_GAMESTATE);
            //    this.Dispose();
            //    nextForm.Show();
            //}
            //else
            //{
            //    GameManager.Instance.FSM_GAMESTATE.SetState(3);
            //    Form nextForm = Program.ChangeForm(GameManager.Instance.FSM_GAMESTATE);
            //    this.Dispose();
            //    nextForm.Show();
            //}

            // Test Code
            GameManager.Instance.AddToRoster(new Character("Player 1"));
            GameManager.Instance.AddToRoster(new Character("Player 2"));
            GameManager.Instance.AddToRoster(new Character("Player 3"));
            GameManager.Instance.AddToRoster(new Character("Player 4"));
            GameManager.Instance.AddToRoster(new Character("Player 5"));
            GameManager.Instance.AddToRoster(new Character("Player 6"));
            GameManager.Instance.AddToRoster(new Character("Player 7"));
            GameManager.Instance.AddToRoster(new Character("Player 8"));
            GameManager.Instance.AddToRoster(new Character("Player 9"));
            GameManager.Instance.AddToRoster(new Character("Player 10"));
            GameManager.Instance.AddToRoster(new Character("Player 11"));
            GameManager.Instance.AddToRoster(new Character("Player 12"));
            GameManager.Instance.AddToRoster(new Character("Player 13"));
            GameManager.Instance.AddToRoster(new Character("Player 14"));

            GameManager.Instance.FSM_GAMESTATE.SetState(3);
            Form nextForm = Program.ChangeForm(GameManager.Instance.FSM_GAMESTATE);
            this.Dispose();
            nextForm.Show();
        }

        private void Character_Name_Label_Click(object sender, EventArgs e)
        {

        }
    }
}