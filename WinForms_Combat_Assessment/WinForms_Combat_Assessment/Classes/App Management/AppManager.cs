namespace WinForms_Combat_Assessment
{
    public class AppManager
    {
        private DataManager m_dataManager;

        public DataManager DataManager
        {
            get { return m_dataManager; }
            set { m_dataManager = value; }
        }

        public delegate void Del();
        public Del Initializer;

        public void InitalizeMainFSM()
        {            
            DataManager.MainFSM.AddState(new MainMenuState(0));
            DataManager.MainFSM.AddState(new GameRulesState(1));
            DataManager.MainFSM.AddState(new CharacterSheetState(2));
            DataManager.MainFSM.AddState(new ScoreboardState(3));
            DataManager.MainFSM.AddState(new DiceRollState(4));
            DataManager.MainFSM.AddState(new CombatState(5));

            DataManager.MainFSM.SetState(0);           
        }

        public void InitalizeDataManager()
        {
            DataManager.AddToWeaponList(new Sword("Sword", 25));
            DataManager.AddToWeaponList(new Axe("Axe", 25));
            DataManager.AddToWeaponList(new Mace("Mace", 25));
            DataManager.AddToWeaponList(new Mace("PunkBuster VAC Ban Hammer", 100));

            DataManager.AddToSpellList(new MagicMissle("Magic Missle", 25, 25));
            DataManager.AddToSpellList(new Flashburn("Flashburn", 25, 25));
            DataManager.AddToSpellList(new Blizzard("Blizzard", 25, 25));
            DataManager.AddToSpellList(new LightningBolt("LightningBolt", 25, 25));
            DataManager.AddToSpellList(new Regeneration("Regeneration", 25, 25));
            DataManager.AddToSpellList(new DivineIntervention("DivineIntervention", 25, 25));

            DataManager.AddToItemList(new Potion("Potion", 50, 0));
            DataManager.AddToItemList(new Potion("Ether", 0, 50));
            DataManager.AddToItemList(new Potion("Elixir", 30, 30));
            DataManager.AddToItemList(new RuneStone("Red Runestone", 1, 0));
            DataManager.AddToItemList(new RuneStone("Blue Runestone", 0, 1));
        }

        private static readonly AppManager instance = new AppManager();

        public static AppManager Instance
        {
            get { return instance; }           
        }

        private AppManager()
        {
            DataManager = new DataManager();
            Initializer += InitalizeMainFSM;
            Initializer += InitalizeDataManager;
        }
 

        public static void DoActions()
        {
            instance.DataManager.CurrentPlayer.DoItemAction(instance.DataManager.CurrentPlayer.Info.ItemTarget);
            instance.DataManager.CurrentPlayer.DoWeaponAction(instance.DataManager.CurrentPlayer.Info.AttackTarget);
            instance.DataManager.CurrentPlayer.DoSpellAction(instance.DataManager.CurrentPlayer.Info.SpellTarget);
            instance.CombatLog = "";
            // item action
            var info = instance.DataManager.CurrentPlayer.Info;
            string s1 = string.Format("{0} has used {1} on {2} \n", info.Name, info.ActiveItem.Name, info.ItemTarget.Info.Name);
            string s2 = string.Format("{0} has attacked with {1} on {2} \n", info.Name, info.ActiveWeapon.Name, info.AttackTarget.Info.Name);
            string s3 = string.Format("{0} has cast {1} on {2} \n", info.Name, info.ActiveSpell.Name, info.SpellTarget.Info.Name);
            string s4 = string.Format("Item Info: {0} \nWeapon Info: {1}\n Spell Info: {2}\n", s1, s2, s3);
            instance.CombatLog += s4;
            instance.DataManager.GameRoster.ForEach(x => instance.CombatLog += string.Format("{0} is {1} \n",x.Info.Name, x.Info.Alive));
                 
        }

        public string CombatLog
        {
            get;set;
        }
    }
}