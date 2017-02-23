using System.Collections.Generic;

namespace WinForms_Combat_Assessment
{
    public class AppManager
    {
        public string CombatLog
        {
            get; set;
        }

        public static void DoActions()
        {
            List<int> itemValues = instance.DataManager.CurrentPlayer.DoItemAction(instance.DataManager.CurrentPlayer.Info.ItemTarget);
            int weaponValue = instance.DataManager.CurrentPlayer.DoWeaponAction(instance.DataManager.CurrentPlayer.Info.AttackTarget);
            List<int> spellValues = instance.DataManager.CurrentPlayer.DoSpellAction(instance.DataManager.CurrentPlayer.Info.SpellTarget);
            instance.CombatLog = "";

            var info = instance.DataManager.CurrentPlayer.Info;
            string s1 = string.Format("{0} has used {1} on {2} for {3} healing, {4} mana, {5} strength, {6} intellect. \n", info.Name, info.ActiveItem.Name, info.ItemTarget.Info.Name, itemValues[0], itemValues[1], itemValues[2], itemValues[3]);
            string s2 = string.Format("{0} has attacked {1} with {2} for {3} damage. \n", info.Name, info.AttackTarget.Info.Name, info.ActiveWeapon.Name, weaponValue);
            string s3 = string.Format("{0} has cast {1} on {2} for {3} damage and {4} healing. \n", info.Name, info.ActiveSpell.Name, info.SpellTarget.Info.Name, spellValues[0], spellValues[1]);
            string s4 = string.Format("Item Info: {0} \nWeapon Info: {1}\nSpell Info: {2}\n", s1, s2, s3);
            instance.CombatLog += s4;

            //instance.DataManager.GameRoster.ForEach(x => instance.CombatLog += string.Format("{0} is {1} \n", x.Info.Name, x.Info.Alive));           
        }

        private DataManager m_dataManager;

        public DataManager DataManager
        {
            get { return m_dataManager; }
            set { m_dataManager = value; }
        }

        public delegate void Del();
        public Del Initializer;
        
        public void InitalizeDataManager()
        {
            DataManager = new DataManager();

            DataManager.AddToWeaponList(new Sword("Sword", 25));
            DataManager.AddToWeaponList(new Axe("Axe", 25));
            DataManager.AddToWeaponList(new Mace("Mace", 25));

            DataManager.AddToSpellList(new MagicMissle("Magic Missle", 25, 0, 25));
            DataManager.AddToSpellList(new Flashburn("Flashburn", 25, 0, 25));
            DataManager.AddToSpellList(new Blizzard("Blizzard", 25, 0, 25));
            DataManager.AddToSpellList(new LightningBolt("Lightning Bolt", 25, 0, 25));
            DataManager.AddToSpellList(new Regeneration("Regeneration", 0, 25, 25));
            DataManager.AddToSpellList(new DivineIntervention("Divine Intervention", 0, 25, 25));

            DataManager.AddToItemList(new Potion("Potion", 50, 0));
            DataManager.AddToItemList(new Potion("Ether", 0, 50));
            DataManager.AddToItemList(new Potion("Elixir", 30, 30));
            DataManager.AddToItemList(new RuneStone("Red Runestone", 1, 0));
            DataManager.AddToItemList(new RuneStone("Blue Runestone", 0, 1));
        }

        public void InitalizeMainFSM()
        {
            DataManager.MainFSM = new FSM();

            DataManager.MainFSM.AddState(new MainMenuState(0));
            DataManager.MainFSM.AddState(new GameRulesState(1));
            DataManager.MainFSM.AddState(new CharacterSheetState(2));
            DataManager.MainFSM.AddState(new ScoreboardState(3));
            DataManager.MainFSM.AddState(new DiceRollState(4));
            DataManager.MainFSM.AddState(new CombatState(5));

            DataManager.MainFSM.SetState(0);
        }

        private static readonly AppManager instance = new AppManager();

        public static AppManager Instance
        {
            get { return instance; }           
        }

        private AppManager()
        {
            Initializer += InitalizeDataManager;
            Initializer += InitalizeMainFSM;

            Initializer.Invoke();
        } 
    }
}