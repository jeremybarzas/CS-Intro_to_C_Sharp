using System;
using System.Windows.Forms;

namespace WinForms_Combat_Assessment
{
    public partial class CharacterSheet : Form
    {
        private void FillComboBoxes()
        {
            foreach (Weapon weapon in AppManager.Instance.DataManager.WeaponList)
                Weapon_Selector_1.Items.Add(weapon.Name);

            foreach (Weapon weapon in AppManager.Instance.DataManager.WeaponList)
                Weapon_Selector_2.Items.Add(weapon.Name);

            foreach (Spell spell in AppManager.Instance.DataManager.SpellList)
                Spell_Selector_1.Items.Add(spell.Name);

            foreach (Spell spell in AppManager.Instance.DataManager.SpellList)
                Spell_Selector_2.Items.Add(spell.Name);

            foreach (Item item in AppManager.Instance.DataManager.ItemList)
                Item_Selector_1.Items.Add(item.Name);

            foreach (Item item in AppManager.Instance.DataManager.ItemList)
                Item_Selector_2.Items.Add(item.Name);

            foreach (Item item in AppManager.Instance.DataManager.ItemList)
                Item_Selector_3.Items.Add(item.Name);

            foreach (Item item in AppManager.Instance.DataManager.ItemList)
                Item_Selector_4.Items.Add(item.Name);
        }

        private Character ConfirmSelections()
        {
            Character newCharacter = new Character();

            newCharacter.Info.Name = Character_Name.Text;

            foreach (Weapon weapon in AppManager.Instance.DataManager.WeaponList)
            {
                if (Weapon_Selector_1.SelectedItem.Equals(weapon.Name))
                {
                    newCharacter.AddToWeapons(weapon);
                    break;
                }
            }
            foreach (Weapon weapon in AppManager.Instance.DataManager.WeaponList)
            {
                if (Weapon_Selector_2.SelectedItem.Equals(weapon.Name))
                {
                    newCharacter.AddToWeapons(weapon);
                    break;
                }
            }
            foreach (Spell spell in AppManager.Instance.DataManager.SpellList)
            {
                if (Spell_Selector_1.SelectedItem.Equals(spell.Name))
                {
                    newCharacter.AddToSpellbook(spell);
                    break;
                }
            }
            foreach (Spell spell in AppManager.Instance.DataManager.SpellList)
            {
                if (Spell_Selector_2.SelectedItem.Equals(spell.Name))
                {
                    newCharacter.AddToSpellbook(spell);
                    break;
                }
            }
            foreach (Item item in AppManager.Instance.DataManager.ItemList)
            {
                if (Item_Selector_1.SelectedItem.Equals(item.Name))
                {
                    newCharacter.AddToBackpack(item);
                    break;
                }
            }
            foreach (Item item in AppManager.Instance.DataManager.ItemList)
            {
                if (Item_Selector_2.SelectedItem.Equals(item.Name))
                {
                    newCharacter.AddToBackpack(item);
                    break;
                }
            }
            foreach (Item item in AppManager.Instance.DataManager.ItemList)
            {
                if (Item_Selector_3.SelectedItem.Equals(item.Name))
                {
                    newCharacter.AddToBackpack(item);
                    break;
                }
            }
            foreach (Item item in AppManager.Instance.DataManager.ItemList)
            {
                if (Item_Selector_4.SelectedItem.Equals(item.Name))
                {
                    newCharacter.AddToBackpack(item);
                    break;
                }
            }
                        
            return newCharacter;
        }

        public CharacterSheet()
        {                        
            InitializeComponent();
        }

        private void CharacterSheet_Load(object sender, EventArgs e)
        {
            FillComboBoxes();  
        }

        private void To_Main_Menu_Click(object sender, EventArgs e)
        {
            Program.ChangeForm(0);
        }

        private void Next_Click(object sender, EventArgs e)
        {
            //// Actual Code
            //AppManager.Instance.DataManager.AddToRoster(ConfirmSelections());

            //if (AppManager.Instance.DataManager.GameRoster.Count < AppManager.Instance.DataManager.PlayerCount)
            //    Program.ChangeForm(this, 2);
            //else
            //    Program.ChangeForm(this, 3);

            // Test Code
            AppManager.Instance.DataManager.AddToRoster(new Character("Test Player 1", new Mace("PunkBuster VAC Ban Hammer", 9001), new Sword("Sword", 25), new MagicMissle("Magic Missle", 25,0,25), new Regeneration("Regeneration", 0, 25, 25), new Potion("Potion", 50, 0), new Potion("Ether", 0, 50), new RuneStone("Blue Runestone", 0, 1), new RuneStone("Red Runestone", 1, 0)));
            AppManager.Instance.DataManager.AddToRoster(new Character("Test Player 2", new Mace("PunkBuster VAC Ban Hammer", 9001), new Sword("Sword", 25), new MagicMissle("Magic Missle", 25, 0, 25), new Regeneration("Regeneration", 0, 25, 25), new Potion("Potion", 50, 0), new Potion("Ether", 0, 50), new RuneStone("Blue Runestone", 0, 1), new RuneStone("Red Runestone", 1, 0)));
            AppManager.Instance.DataManager.AddToRoster(new Character("Test Player 3", new Mace("PunkBuster VAC Ban Hammer", 9001), new Sword("Sword", 25), new MagicMissle("Magic Missle", 25, 0, 25), new Regeneration("Regeneration", 0, 25, 25), new Potion("Potion", 50, 0), new Potion("Ether", 0, 50), new RuneStone("Blue Runestone", 0, 1), new RuneStone("Red Runestone", 1, 0)));
            AppManager.Instance.DataManager.AddToRoster(new Character("Test Player 4", new Mace("PunkBuster VAC Ban Hammer", 9001), new Sword("Sword", 25), new MagicMissle("Magic Missle", 25, 0, 25), new Regeneration("Regeneration", 0, 25, 25), new Potion("Potion", 50, 0), new Potion("Ether", 0, 50), new RuneStone("Blue Runestone", 0, 1), new RuneStone("Red Runestone", 1, 0)));
            AppManager.Instance.DataManager.AddToRoster(new Character("Test Player 5", new Mace("PunkBuster VAC Ban Hammer", 9001), new Sword("Sword", 25), new MagicMissle("Magic Missle", 25, 0, 25), new Regeneration("Regeneration", 0, 25, 25), new Potion("Potion", 50, 0), new Potion("Ether", 0, 50), new RuneStone("Blue Runestone", 0, 1), new RuneStone("Red Runestone", 1, 0)));
            AppManager.Instance.DataManager.AddToRoster(new Character("Test Player 6", new Mace("PunkBuster VAC Ban Hammer", 9001), new Sword("Sword", 25), new MagicMissle("Magic Missle", 25, 0, 25), new Regeneration("Regeneration", 0, 25, 25), new Potion("Potion", 50, 0), new Potion("Ether", 0, 50), new RuneStone("Blue Runestone", 0, 1), new RuneStone("Red Runestone", 1, 0)));
            AppManager.Instance.DataManager.AddToRoster(new Character("Test Player 7", new Mace("PunkBuster VAC Ban Hammer", 9001), new Sword("Sword", 25), new MagicMissle("Magic Missle", 25, 0, 25), new Regeneration("Regeneration", 0, 25, 25), new Potion("Potion", 50, 0), new Potion("Ether", 0, 50), new RuneStone("Blue Runestone", 0, 1), new RuneStone("Red Runestone", 1, 0)));
            AppManager.Instance.DataManager.AddToRoster(new Character("Test Player 8", new Mace("PunkBuster VAC Ban Hammer", 9001), new Sword("Sword", 25), new MagicMissle("Magic Missle", 25, 0, 25), new Regeneration("Regeneration", 0, 25, 25), new Potion("Potion", 50, 0), new Potion("Ether", 0, 50), new RuneStone("Blue Runestone", 0, 1), new RuneStone("Red Runestone", 1, 0)));
            AppManager.Instance.DataManager.AddToRoster(new Character("Test Player 9", new Mace("PunkBuster VAC Ban Hammer", 9001), new Sword("Sword", 25), new MagicMissle("Magic Missle", 25, 0, 25), new Regeneration("Regeneration", 0, 25, 25), new Potion("Potion", 50, 0), new Potion("Ether", 0, 50), new RuneStone("Blue Runestone", 0, 1), new RuneStone("Red Runestone", 1, 0)));
            AppManager.Instance.DataManager.AddToRoster(new Character("Test Player 10", new Mace("PunkBuster VAC Ban Hammer", 9001), new Sword("Sword", 25), new MagicMissle("Magic Missle", 25, 0, 25), new Regeneration("Regeneration", 0, 25, 25), new Potion("Potion", 50, 0), new Potion("Ether", 0, 50), new RuneStone("Blue Runestone", 0, 1), new RuneStone("Red Runestone", 1, 0)));

            Program.ChangeForm(this, 3);
        }
    }    
}