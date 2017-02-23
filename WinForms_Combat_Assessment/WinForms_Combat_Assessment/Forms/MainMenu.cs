using System;
using System.Windows.Forms;

namespace WinForms_Combat_Assessment
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void New_Game_Click(object sender, EventArgs e)
        {
            AppManager.Instance.Initializer.Invoke();
            Program.ChangeForm(this, 1);
        }

        private void Load_Game_Click(object sender, EventArgs e)
        {            
            AppManager.Instance.DataManager = DataSerializer<DataManager>.Deserialize("GameSave");

            Program.ChangeForm(this, 3);
        }

        private void Exit_Game_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Debug_Mode_Click(object sender, EventArgs e)
        {
            AppManager.Instance.Initializer.Invoke();

            AppManager.Instance.DataManager.AddToRoster(new Character("Test Player 1", new Mace("PunkBuster VAC Ban Hammer", 9001), new Sword("Sword", 25), new MagicMissle("Magic Missle", 25, 0, 25), new Regeneration("Regeneration", 0, 25, 25), new Potion("Potion", 50, 0), new Potion("Ether", 0, 50), new RuneStone("Blue Runestone", 0, 1), new RuneStone("Red Runestone", 1, 0)));
            AppManager.Instance.DataManager.AddToRoster(new Character("Test Player 2", new Mace("PunkBuster VAC Ban Hammer", 9001), new Sword("Sword", 25), new MagicMissle("Magic Missle", 25, 0, 25), new Regeneration("Regeneration", 0, 25, 25), new Potion("Potion", 50, 0), new Potion("Ether", 0, 50), new RuneStone("Blue Runestone", 0, 1), new RuneStone("Red Runestone", 1, 0)));
            AppManager.Instance.DataManager.AddToRoster(new Character("Test Player 3", new Mace("PunkBuster VAC Ban Hammer", 9001), new Sword("Sword", 25), new MagicMissle("Magic Missle", 25, 0, 25), new Regeneration("Regeneration", 0, 25, 25), new Potion("Potion", 50, 0), new Potion("Ether", 0, 50), new RuneStone("Blue Runestone", 0, 1), new RuneStone("Red Runestone", 1, 0)));
            AppManager.Instance.DataManager.AddToRoster(new Character("Test Player 4", new Mace("PunkBuster VAC Ban Hammer", 9001), new Sword("Sword", 25), new MagicMissle("Magic Missle", 25, 0, 25), new Regeneration("Regeneration", 0, 25, 25), new Potion("Potion", 50, 0), new Potion("Ether", 0, 50), new RuneStone("Blue Runestone", 0, 1), new RuneStone("Red Runestone", 1, 0)));
            AppManager.Instance.DataManager.AddToRoster(new Character("Test Player 5", new Mace("PunkBuster VAC Ban Hammer", 9001), new Sword("Sword", 25), new MagicMissle("Magic Missle", 25, 0, 25), new Regeneration("Regeneration", 0, 25, 25), new Potion("Potion", 50, 0), new Potion("Ether", 0, 50), new RuneStone("Blue Runestone", 0, 1), new RuneStone("Red Runestone", 1, 0)));

            Program.ChangeForm(this, 3);
        }
    }
}