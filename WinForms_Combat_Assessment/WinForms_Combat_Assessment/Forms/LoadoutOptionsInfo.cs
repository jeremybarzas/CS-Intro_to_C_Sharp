using System;
using System.Windows.Forms;

namespace WinForms_Combat_Assessment
{
    public partial class LoadoutOptionsInfo : Form
    {
        public LoadoutOptionsInfo()
        {
            InitializeComponent();
        }

        private void LoadoutOptionsInfo_Load(object sender, EventArgs e)
        {
            if (AppManager.Instance.DataManager.MainFSM.PreviousStateId == 5)
            {
                Loadout_Options_Info_Text.Text += "==================== Available Weapons ====================\n\n";
                foreach (Weapon weapon in AppManager.Instance.DataManager.CurrentPlayer.Info.Weapons)
                    Loadout_Options_Info_Text.Text += weapon.WeaponInfo + "\n\n";

                Loadout_Options_Info_Text.Text += "==================== Available Items ====================\n\n";
                foreach (Item item in AppManager.Instance.DataManager.CurrentPlayer.Info.Backpack)
                    Loadout_Options_Info_Text.Text += item.ItemInfo + "\n\n";

                Loadout_Options_Info_Text.Text += "==================== Available Spells ====================\n\n";
                foreach (Spell spell in AppManager.Instance.DataManager.CurrentPlayer.Info.Spellbook)
                    Loadout_Options_Info_Text.Text += spell.SpellInfo + "\n\n";
            }
            if (AppManager.Instance.DataManager.MainFSM.PreviousStateId == 2)
            {
                Loadout_Options_Info_Text.Text += "==================== Available Weapons ====================\n\n";
                foreach (Weapon weapon in AppManager.Instance.DataManager.WeaponList)
                    Loadout_Options_Info_Text.Text += weapon.WeaponInfo + "\n\n";

                Loadout_Options_Info_Text.Text += "==================== Available Items ====================\n\n";
                foreach (Item item in AppManager.Instance.DataManager.ItemList)
                    Loadout_Options_Info_Text.Text += item.ItemInfo + "\n\n";

                Loadout_Options_Info_Text.Text += "==================== Available Spells ====================\n\n";
                foreach (Spell spell in AppManager.Instance.DataManager.SpellList)
                    Loadout_Options_Info_Text.Text += spell.SpellInfo + "\n\n";
            }
        }

        private void Back_To_Previous_Click(object sender, EventArgs e)
        {
            Program.ChangeForm(this, AppManager.Instance.DataManager.MainFSM.PreviousStateId);
        }
    }
}