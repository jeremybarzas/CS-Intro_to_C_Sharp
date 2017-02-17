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

            Combat_Phase_Label.Text = "Combat Round " + FormManager.Instance.DataManager.RoundNumber;                                
            Current_Player_Name_Label.Text = FormManager.Instance.DataManager.CurrentPlayer.Info.Name + "'s Turn";

            foreach (Character character in FormManager.Instance.DataManager.GameRoster)
                Attack_Target_Selector.Items.Add(character);

            foreach (Character character in FormManager.Instance.DataManager.GameRoster)
                Spell_Target_Selector.Items.Add(character);

            foreach (Character character in FormManager.Instance.DataManager.GameRoster)
                Item_Target_Selector.Items.Add(character);

            foreach (Weapon weapon in FormManager.Instance.DataManager.WeaponList)
                Attack_Selector.Items.Add(weapon);

            foreach (Spell spell in FormManager.Instance.DataManager.SpellList)
                Spell_Selector.Items.Add(spell);

            foreach (Item item in FormManager.Instance.DataManager.ItemList)
                Item_Selector.Items.Add(item);
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

            Attack_Target_Selector.Enabled = false;
            Item_Target_Selector.Enabled = false;
            Spell_Target_Selector.Enabled = false;

            Confirm.Enabled = false;
            End_Turn.Enabled = true;
        }

        private void End_Turn_Click(object sender, EventArgs e)
        {
            if (FormManager.Instance.DataManager.TurnCount >= FormManager.Instance.DataManager.RemainingPlayers - 1)
            {
                FormManager.Instance.DataManager.RoundNumber++;
                FormManager.Instance.DataManager.TurnCount = 0;

                Program.ChangeForm(this, 3);
            }
            else
            {
                FormManager.Instance.DataManager.TurnCount += 1;
                FormManager.Instance.DataManager.SetCurrentPlayer();

                Program.ChangeForm(this, 5);
            }
        }

        private void Item_Selector_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}