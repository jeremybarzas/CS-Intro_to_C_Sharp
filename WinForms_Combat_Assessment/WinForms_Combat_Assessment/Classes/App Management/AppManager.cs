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
    }
}