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
    public partial class Combat : Form
    {
        public Combat()
        {
            InitializeComponent();
        }

        private void Combat_Load(object sender, EventArgs e)
        {
            End_Turn.Enabled = false;

            Combat_Phase_Label.Text = "Combat Round " + GameManager.Instance.RoundNumber;                                
            Current_Player_Name_Label.Text = GameManager.Instance.CurrentPlayer.Name + "'s Turn";
        }

        private void To_Main_Menu_Click(object sender, EventArgs e)
        {
            GameManager.Instance.FSM.SetState(0);
            Form nextForm = Program.ChangeForm(GameManager.Instance.FSM);
            this.Dispose();
            nextForm.Show();
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
            if (GameManager.Instance.TurnCount >= GameManager.Instance.RemainingPlayers - 1)
            {
                GameManager.Instance.RoundNumber++;
                GameManager.Instance.TurnCount = 0;

                GameManager.Instance.FSM.SetState(3);
                Form scoreboard = Program.ChangeForm(GameManager.Instance.FSM);
                this.Dispose();
                scoreboard.Show();
            }
            else
            {
                GameManager.Instance.TurnCount += 1;
                GameManager.Instance.SetCurrentPlayer();
                
                GameManager.Instance.FSM.SetState(5);
                Form combatPhase = Program.ChangeForm(GameManager.Instance.FSM);
                this.Dispose();
                combatPhase.Show();
            }            
        }
    }
}