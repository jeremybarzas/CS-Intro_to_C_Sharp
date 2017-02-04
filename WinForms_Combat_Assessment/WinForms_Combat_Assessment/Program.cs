using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WinForms_Combat_Assessment
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            MainMenuState MainMenu = new MainMenuState();
            GameRulesState GameRules = new GameRulesState();
            CharacterSheetState CharacterSheet = new CharacterSheetState();
            ScoreboardState Scoreboard = new ScoreboardState();
            DiceRollState DiceRoll = new DiceRollState();
            CombatState Combat = new CombatState();

            FSM fsm = new FSM();

            fsm.AddState(MainMenu);
            fsm.AddState(GameRules);
            fsm.AddState(CharacterSheet);
            fsm.AddState(Scoreboard);
            fsm.AddState(DiceRoll);
            fsm.AddState(Combat);

            GameManager.Instance.FSM_GAMESTATE = fsm;           

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainMenu());
        }
    }
}