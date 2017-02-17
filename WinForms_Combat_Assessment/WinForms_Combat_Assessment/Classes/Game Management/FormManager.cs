namespace WinForms_Combat_Assessment
{
    public class FormManager
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
            DataManager.AddToWeaponList(new Sword());
            DataManager.AddToWeaponList(new Axe());
            DataManager.AddToWeaponList(new Mace());

            DataManager.AddToSpellList(new MagicMissle());
            DataManager.AddToSpellList(new Flashburn());
            DataManager.AddToSpellList(new Blizzard());
            DataManager.AddToSpellList(new LightningBolt());
            DataManager.AddToSpellList(new Regeneration());
            DataManager.AddToSpellList(new DivineIntervention());

            DataManager.AddToItemList(new Potion());
            DataManager.AddToItemList(new RuneStone());
        }

        private static readonly FormManager instance = new FormManager();

        public static FormManager Instance
        {
            get { return instance; }           
        }

        private FormManager()
        {
            DataManager = new DataManager();
            Initializer += InitalizeMainFSM;
            Initializer += InitalizeDataManager;
        }
    }
}