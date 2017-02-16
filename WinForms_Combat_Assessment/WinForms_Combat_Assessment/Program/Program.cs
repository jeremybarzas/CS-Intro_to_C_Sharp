using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Collections.Generic;
namespace WinForms_Combat_Assessment
{
   
    static class Program
    {
        public static Form ChangeForm(FSM fsm)
        {
            State current = fsm.CurrentState;

            Form currentForm = new Form();

            //if (current as MainMenuState != null)
            //  currentForm = new MainMenu();

            if (current as GameRulesState != null)
                currentForm = new GameRules();

            if (current as CharacterSheetState != null)
                currentForm = new CharacterSheet();

            if (current as ScoreboardState != null)
                currentForm = new Scoreboard();

            if (current as DiceRollState != null)
                currentForm = new DiceRoll();

            if (current as CombatState != null)
                currentForm = new Combat();

            return currentForm;
        }


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            FSM fsm = new FSM();
            GameManager.Instance.DataManager.FSM = fsm;
            var gm = GameManager.Instance.DataManager;

            State MainMenu = new MainMenuState(0);
            
            XmlSerializer ser = new XmlSerializer(typeof(FSM));
            TextWriter tw = new StreamWriter(Environment.CurrentDirectory + "../Saves/" + "mainmenu" + ".xml");

            //CharacterSheetState CharacterSheet = new CharacterSheetState(2);
            //ScoreboardState Scoreboard = new ScoreboardState(3);
            //DiceRollState DiceRoll = new DiceRollState(4);
            //CombatState Combat = new CombatState(5);
            GameRulesState GameRules = new GameRulesState(1);
            
            fsm.AddState(new MainMenuState());
            
            //fsm.AddState(Scoreboard);
            
            fsm.AddState(GameRules);
            GameSerialization<DataManager>.Serialize("GameSave", gm);
            //fsm.AddState(CharacterSheet);


            //fsm.AddState(DiceRoll);
            //fsm.AddState(Combat);
            //fsm.SetState(0);










            GameManager.Instance.DataManager.FSM = fsm;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainMenu());
        }
    }
}