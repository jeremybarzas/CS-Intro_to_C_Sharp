using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WinForms_Combat_Assessment
{   
    static class Program
    {
        public static Form ChangeForm(FSM fsm)
        {
            IGameState current = fsm.CurrentState;

            Form currentForm = new Form();

            if (current as MainMenuState != null)
                currentForm = new MainMenu();

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

            var MainMenu = new MainMenuState(0);
            var GameRules = new GameRulesState(1);
            var CharacterSheet = new CharacterSheetState(2);
            var Scoreboard = new ScoreboardState(3);
            var DiceRoll = new DiceRollState(4);
            var Combat = new CombatState(5);

            fsm.AddState(MainMenu);
            fsm.AddState(GameRules);
            fsm.AddState(CharacterSheet);
            fsm.AddState(Scoreboard);
            fsm.AddState(DiceRoll);
            fsm.AddState(Combat);

            fsm.SetState(MainMenu);

            GameManager.Instance.FSM = fsm;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainMenu());           
        }
    }
}