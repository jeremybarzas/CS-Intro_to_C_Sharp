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
            newCharacter = new Character();
        }

        private void CharacterSheet_Load(object sender, EventArgs e)
        {

        }

        private void Character_Name_TextChanged(object sender, EventArgs e)
        {
            newCharacter.Name = Character_Name.Text;
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
            GameManager.Instance.AddToRoster(newCharacter);

            if (GameManager.Instance.GameRoster.Count < GameManager.Instance.PlayerCount)
            {
                GameManager.Instance.FSM_GAMESTATE.SetState(2);
                Form nextForm = Program.ChangeForm(GameManager.Instance.FSM_GAMESTATE);
                this.Hide();
                nextForm.Show();
            }
            else
            { 
                GameManager.Instance.FSM_GAMESTATE.SetState(3);
                Form nextForm = Program.ChangeForm(GameManager.Instance.FSM_GAMESTATE);
                this.Hide();
                nextForm.Show();
            }
        }

        private void Character_Name_Label_Click(object sender, EventArgs e)
        {

        }
    }
}