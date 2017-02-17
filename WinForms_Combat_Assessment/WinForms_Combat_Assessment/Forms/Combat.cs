using System;
using System.Windows.Forms;

namespace WinForms_Combat_Assessment
{
    public partial class Combat : Form
    {
        public Combat()
        {
            InitializeComponent();
        }

        private void Combat_Load(object sender, EventArgs e)
        {
            End_Turn.Enabled = false;

            Combat_Phase_Label.Text = "Combat Round " + GameManager.Instance.DataManager.RoundNumber;                                
            Current_Player_Name_Label.Text = GameManager.Instance.DataManager.CurrentPlayer.Name + "'s Turn";
        }

        private void To_Main_Menu_Click(object sender, EventArgs e)
        {
            Program.ChangeForm(0);
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            Attack_Selector.Enabled = false;
            Item_Selector.Enabled = false;
            Spell_Selector.Enabled = false;

            Select_Attack_Target.Enabled = false;
            Select_Item_Target.Enabled = false;
            Select_Spell_Target.Enabled = false;

            Confirm.Enabled = false;
            End_Turn.Enabled = true;
        }

        private void End_Turn_Click(object sender, EventArgs e)
        {
            if (GameManager.Instance.DataManager.TurnCount >= GameManager.Instance.DataManager.RemainingPlayers - 1)
            {
                GameManager.Instance.DataManager.RoundNumber++;
                GameManager.Instance.DataManager.TurnCount = 0;

                Program.ChangeForm(this, 3);
            }
            else
            {
                GameManager.Instance.DataManager.TurnCount += 1;
                GameManager.Instance.DataManager.SetCurrentPlayer();

                Program.ChangeForm(this, 5);
            }            
        }

        private void Item_Selector_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}