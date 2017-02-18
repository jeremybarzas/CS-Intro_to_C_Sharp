using System;
using System.Windows.Forms;

namespace WinForms_Combat_Assessment
{
    public partial class Combat : Form
    {        
        private void FillComboBoxes()
        {
            // atack spell item select
            foreach (Weapon weapon in AppManager.Instance.DataManager.CurrentPlayer.Info.Weapons)
                Attack_Selector.Items.Add(weapon.Name);

            foreach (Spell spell in AppManager.Instance.DataManager.CurrentPlayer.Info.Spellbook)
                Spell_Selector.Items.Add(spell.Name);

            foreach (Item item in AppManager.Instance.DataManager.CurrentPlayer.Info.Backpack)
                Item_Selector.Items.Add(item.Name);

            // target select
            foreach (Character character in AppManager.Instance.DataManager.GameRoster)
                if (character.Info.Alive == true)
                    Attack_Target_Selector.Items.Add(character.Info.Name);

            foreach (Character character in AppManager.Instance.DataManager.GameRoster)
                if (character.Info.Alive == true)
                    Spell_Target_Selector.Items.Add(character.Info.Name);

            foreach (Character character in AppManager.Instance.DataManager.GameRoster)
                if (character.Info.Alive == true)
                    Item_Target_Selector.Items.Add(character.Info.Name);
        }

        private void ConfirmSelctions()
        {
            foreach (Weapon weapon in AppManager.Instance.DataManager.CurrentPlayer.Info.Weapons)
            {
                if (Attack_Selector.SelectedItem.Equals(weapon.Name))
                {
                    AppManager.Instance.DataManager.CurrentPlayer.Info.ActiveWeapon = weapon;
                    break;
                }
            }

            foreach (Item item in AppManager.Instance.DataManager.CurrentPlayer.Info.Backpack)
            {
                if (Item_Selector.SelectedItem.Equals(item.Name))
                {
                    AppManager.Instance.DataManager.CurrentPlayer.Info.ActiveItem = item;
                    break;
                }
            }

            foreach (Spell spell in AppManager.Instance.DataManager.CurrentPlayer.Info.Spellbook)
            {
                if (Spell_Selector.SelectedItem.Equals(spell.Name))
                {
                    AppManager.Instance.DataManager.CurrentPlayer.Info.ActiveSpell = spell;
                    break;
                }
            }

            foreach (Character character in AppManager.Instance.DataManager.GameRoster)
            {
                if (Attack_Target_Selector.SelectedItem.Equals(character.Info.Name))
                {
                    AppManager.Instance.DataManager.CurrentPlayer.Info.AttackTarget = character;
                    break;
                }
            }

            foreach (Character character in AppManager.Instance.DataManager.GameRoster)
            {
                if (Item_Target_Selector.SelectedItem.Equals(character.Info.Name))
                {
                    AppManager.Instance.DataManager.CurrentPlayer.Info.ItemTarget = character;
                    break;
                }
            }

            foreach (Character character in AppManager.Instance.DataManager.GameRoster)
            {
                if (Spell_Target_Selector.SelectedItem.Equals(character.Info.Name))
                {
                    AppManager.Instance.DataManager.CurrentPlayer.Info.SpellTarget = character;
                    break;
                }
            }            
        }

        private void ResolveActions()
        {            
            AppManager.Instance.DataManager.CurrentPlayer.DoItemAction(AppManager.Instance.DataManager.CurrentPlayer.Info.ItemTarget);
            AppManager.Instance.DataManager.CurrentPlayer.DoWeaponAction(AppManager.Instance.DataManager.CurrentPlayer.Info.AttackTarget);
            AppManager.Instance.DataManager.CurrentPlayer.DoSpellAction(AppManager.Instance.DataManager.CurrentPlayer.Info.SpellTarget);            
        }

        private void FillCombatText()
        {
            // item action
            Combat_Textbox.Text += AppManager.Instance.DataManager.CurrentPlayer.Info.Name;
            Combat_Textbox.Text += " has used " + AppManager.Instance.DataManager.CurrentPlayer.Info.ActiveItem.Name;
            Combat_Textbox.Text += " on " + AppManager.Instance.DataManager.CurrentPlayer.Info.ItemTarget.Info.Name + ".\n\n";

            if (AppManager.Instance.DataManager.GameRoster[AppManager.Instance.DataManager.GameRoster.IndexOf(AppManager.Instance.DataManager.CurrentPlayer.Info.ItemTarget)].Info.Alive == false)               
                Combat_Textbox.Text += AppManager.Instance.DataManager.CurrentPlayer.Info.ItemTarget.Info.Name + " has been killed.\n\n";

            // attack action
            Combat_Textbox.Text += AppManager.Instance.DataManager.CurrentPlayer.Info.Name + " has attacked ";
            Combat_Textbox.Text += AppManager.Instance.DataManager.CurrentPlayer.Info.AttackTarget.Info.Name;
            Combat_Textbox.Text += " with " + AppManager.Instance.DataManager.CurrentPlayer.Info.ActiveWeapon.Name + ".\n\n";

            if (AppManager.Instance.DataManager.GameRoster[AppManager.Instance.DataManager.GameRoster.IndexOf(AppManager.Instance.DataManager.CurrentPlayer.Info.AttackTarget)].Info.Alive == false)
                Combat_Textbox.Text += AppManager.Instance.DataManager.CurrentPlayer.Info.AttackTarget.Info.Name + " has been killed.\n\n";

            // spell action
            Combat_Textbox.Text += AppManager.Instance.DataManager.CurrentPlayer.Info.Name;
            Combat_Textbox.Text += " has cast " + AppManager.Instance.DataManager.CurrentPlayer.Info.ActiveSpell.Name;
            Combat_Textbox.Text += " on " + AppManager.Instance.DataManager.CurrentPlayer.Info.SpellTarget.Info.Name + ".\n\n";

            if (AppManager.Instance.DataManager.GameRoster[AppManager.Instance.DataManager.GameRoster.IndexOf(AppManager.Instance.DataManager.CurrentPlayer.Info.SpellTarget)].Info.Alive == false)
                Combat_Textbox.Text += AppManager.Instance.DataManager.CurrentPlayer.Info.SpellTarget.Info.Name + " has been killed.\n\n";
        }

        public Combat()
        {
            InitializeComponent();
        }

        private void Combat_Load(object sender, EventArgs e)
        {
            End_Turn.Enabled = false;

            Combat_Phase_Label.Text = "Combat Round " + AppManager.Instance.DataManager.RoundNumber;                                
            Current_Player_Name_Label.Text = AppManager.Instance.DataManager.CurrentPlayer.Info.Name + "'s Turn";

            FillComboBoxes();
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

            ConfirmSelctions();
            ResolveActions();
            FillCombatText();
        }

        private void End_Turn_Click(object sender, EventArgs e)
        {
            if (AppManager.Instance.DataManager.TurnCount >= AppManager.Instance.DataManager.RemainingPlayers - 1)
            {
                AppManager.Instance.DataManager.RoundNumber++;
                AppManager.Instance.DataManager.TurnCount = 0;

                Program.ChangeForm(this, 3);
            }
            else
            {
                AppManager.Instance.DataManager.TurnCount += 1;
                AppManager.Instance.DataManager.SetCurrentPlayer(AppManager.Instance.DataManager.GameRoster.IndexOf(AppManager.Instance.DataManager.CurrentPlayer) + 1);

                Program.ChangeForm(this, 5);
            }
        }

        private void Attack_Selector_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Item_Selector_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }        

        private void Spell_Selector_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Attack_Target_Selector_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Item_Target_Selector_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Spell_Target_Selector_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}