namespace WinForms_Combat_Assessment
{
    public class GameManager
    {        
        // Use this function to initialize the FSM
        public void SetupFSM()
        {            
            //// 3rd method
            DataManager.FSM.AddState(new MainMenuState(0));
            DataManager.FSM.AddState(new GameRulesState(1));
            DataManager.FSM.AddState(new CharacterSheetState(2));
            DataManager.FSM.AddState(new ScoreboardState(3));
            DataManager.FSM.AddState(new DiceRollState(4));
            DataManager.FSM.AddState(new CombatState(5));

            DataManager.FSM.SetState(0);

            //// 2nd method
            //List<State> states = new List<State>();

            //states.Add(new MainMenuState(0));
            //states.Add(new GameRulesState(1));
            //states.Add(new CharacterSheetState(2));
            //states.Add(new ScoreboardState(3));
            //states.Add(new DiceRollState(4));
            //states.Add(new CombatState(5));

            //// 1st method
            //DataManager.FSM = new FSM(states);

            //FSM fsm = new FSM();

            //var MainMenu = new MainMenuState(0);
            //var GameRules = new GameRulesState(1);
            //var CharacterSheet = new CharacterSheetState(2);
            //var Scoreboard = new ScoreboardState(3);
            //var DiceRoll = new DiceRollState(4);
            //var Combat = new CombatState(5);

            //fsm.AddState(MainMenu);
            //fsm.AddState(Scoreboard);
            //fsm.AddState(GameRules);
            //fsm.AddState(CharacterSheet);
            //fsm.AddState(DiceRoll);
            //fsm.AddState(Combat);

            //fsm.SetState(0);

            //DataManager.FSM = fsm;
        }                

        public delegate void Del();
        public Del Initializer;       

        public DataManager DataManager { get; set; }

        private GameManager()
        {
            DataManager = new DataManager();
            Initializer += SetupFSM;
        }

        private static readonly GameManager instance = new GameManager();

        public static GameManager Instance
        {
            get { return instance; }           
        }
    }
}