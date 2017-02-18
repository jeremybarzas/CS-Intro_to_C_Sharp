using System;
using System.Windows.Forms;

namespace WinForms_Combat_Assessment
{
    public partial class Combat : Form
    {        
        private void FillComboBoxes()
        {
            // atack spell item select
            foreach (Weapon weapon in FormManager.Instance.DataManager.CurrentPlayer.Info.Weapons)
                Attack_Selector.Items.Add(weapon.Name);

            foreach (Spell spell in FormManager.Instance.DataManager.CurrentPlayer.Info.Spellbook)
                Spell_Selector.Items.Add(spell.Name);

            foreach (Item item in FormManager.Instance.DataManager.CurrentPlayer.Info.Backpack)
                Item_Selector.Items.Add(item.Name);

            // target select
            foreach (Character character in FormManager.Instance.DataManager.GameRoster)
                if (character.Info.Alive == true)
                    Attack_Target_Selector.Items.Add(character.Info.Name);

            foreach (Character character in FormManager.Instance.DataManager.GameRoster)
                if (character.Info.Alive == true)
                    Spell_Target_Selector.Items.Add(character.Info.Name);

            foreach (Character character in FormManager.Instance.DataManager.GameRoster)
                if (character.Info.Alive == true)
                    Item_Target_Selector.Items.Add(character.Info.Name);
        }

        private void ConfirmSelctions()
        {
            foreach (Weapon weapon in FormManager.Instance.DataManager.CurrentPlayer.Info.Weapons)
            {
                if (Attack_Selector.SelectedItem.Equals(weapon.Name))
                {
                    FormManager.Instance.DataManager.CurrentPlayer.Info.ActiveWeapon = weapon;
                    break;
                }
            }

            foreach (Item item in FormManager.Instance.DataManager.CurrentPlayer.Info.Backpack)
            {
                if (Item_Selector.SelectedItem.Equals(item.Name))
                {
                    FormManager.Instance.DataManager.CurrentPlayer.Info.ActiveItem = item;
                    break;
                }
            }

            foreach (Spell spell in FormManager.Instance.DataManager.CurrentPlayer.Info.Spellbook)
            {
                if (Spell_Selector.SelectedItem.Equals(spell.Name))
                {
                    FormManager.Instance.DataManager.CurrentPlayer.Info.ActiveSpell = spell;
                    break;
                }
            }

            foreach (Character character in FormManager.Instance.DataManager.GameRoster)
            {
                if (Attack_Target_Selector.SelectedItem.Equals(character.Info.Name))
                {
                    FormManager.Instance.DataManager.CurrentPlayer.Info.AttackTarget = character;
                    break;
                }
            }

            foreach (Character character in FormManager.Instance.DataManager.GameRoster)
            {
                if (Item_Target_Selector.SelectedItem.Equals(character.Info.Name))
                {
                    FormManager.Instance.DataManager.CurrentPlayer.Info.ItemTarget = character;
                    break;
                }
            }

            foreach (Character character in FormManager.Instance.DataManager.GameRoster)
            {
                if (Spell_Target_Selector.SelectedItem.Equals(character.Info.Name))
                {
                    FormManager.Instance.DataManager.CurrentPlayer.Info.SpellTarget = character;
                    break;
                }
            }            
        }

        private void ResolveActions()
        {            
            FormManager.Instance.DataManager.CurrentPlayer.DoItemAction(FormManager.Instance.DataManager.CurrentPlayer.Info.ItemTarget);
            FormManager.Instance.DataManager.CurrentPlayer.DoWeaponAction(FormManager.Instance.DataManager.CurrentPlayer.Info.AttackTarget);
            FormManager.Instance.DataManager.CurrentPlayer.DoSpellAction(FormManager.Instance.DataManager.CurrentPlayer.Info.SpellTarget);            
        }

        private void FillCombatText()
        {
            // item action
            Combat_Textbox.Text += FormManager.Instance.DataManager.CurrentPlayer.Info.Name;
            Combat_Textbox.Text += " has used " + FormManager.Instance.DataManager.CurrentPlayer.Info.ActiveItem.Name;
            Combat_Textbox.Text += " on " + FormManager.Instance.DataManager.CurrentPlayer.Info.ItemTarget.Info.Name + ".\n\n";

            if (FormManager.Instance.DataManager.GameRoster[FormManager.Instance.DataManager.GameRoster.IndexOf(FormManager.Instance.DataManager.CurrentPlayer.Info.ItemTarget)].Info.Alive == false)               
                Combat_Textbox.Text += FormManager.Instance.DataManager.CurrentPlayer.Info.ItemTarget.Info.Name + " has been killed.\n\n";

            // attack action
            Combat_Textbox.Text += FormManager.Instance.DataManager.CurrentPlayer.Info.Name + " has attacked ";
            Combat_Textbox.Text += FormManager.Instance.DataManager.CurrentPlayer.Info.AttackTarget.Info.Name;
            Combat_Textbox.Text += " with " + FormManager.Instance.DataManager.CurrentPlayer.Info.ActiveWeapon.Name + ".\n\n";

            if (FormManager.Instance.DataManager.GameRoster[FormManager.Instance.DataManager.GameRoster.IndexOf(FormManager.Instance.DataManager.CurrentPlayer.Info.AttackTarget)].Info.Alive == false)
                Combat_Textbox.Text += FormManager.Instance.DataManager.CurrentPlayer.Info.AttackTarget.Info.Name + " has been killed.\n\n";

            // spell action
            Combat_Textbox.Text += FormManager.Instance.DataManager.CurrentPlayer.Info.Name;
            Combat_Textbox.Text += " has cast " + FormManager.Instance.DataManager.CurrentPlayer.Info.ActiveSpell.Name;
            Combat_Textbox.Text += " on " + FormManager.Instance.DataManager.CurrentPlayer.Info.SpellTarget.Info.Name + ".\n\n";

            if (FormManager.Instance.DataManager.GameRoster[FormManager.Instance.DataManager.GameRoster.IndexOf(FormManager.Instance.DataManager.CurrentPlayer.Info.SpellTarget)].Info.Alive == false)
                Combat_Textbox.Text += FormManager.Instance.DataManager.CurrentPlayer.Info.SpellTarget.Info.Name + " has been killed.\n\n";
        }

        public Combat()
        {
            InitializeComponent();
        }

        private void Combat_Load(object sender, EventArgs e)
        {
            End_Turn.Enabled = false;

            Combat_Phase_Label.Text = "Combat Round " + FormManager.Instance.DataManager.RoundNumber;                                
            Current_Player_Name_Label.Text = FormManager.Instance.DataManager.CurrentPlayer.Info.Name + "'s Turn";

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
            if (FormManager.Instance.DataManager.TurnCount >= FormManager.Instance.DataManager.RemainingPlayers - 1)
            {
                FormManager.Instance.DataManager.RoundNumber++;
                FormManager.Instance.DataManager.TurnCount = 0;

                Program.ChangeForm(this, 3);
            }
            else
            {
                FormManager.Instance.DataManager.TurnCount += 1;
                FormManager.Instance.DataManager.SetCurrentPlayer(FormManager.Instance.DataManager.GameRoster.IndexOf(FormManager.Instance.DataManager.CurrentPlayer) + 1);

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