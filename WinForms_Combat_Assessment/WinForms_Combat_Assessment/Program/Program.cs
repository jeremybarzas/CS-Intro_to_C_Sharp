using System;
using System.Windows.Forms;

namespace WinForms_Combat_Assessment
{
    static class Program
    {
        public static Form ChangeForm(Form f, int i)
        {
            Form nextForm = new Form();

            AppManager.Instance.DataManager.MainFSM.SetState(i);

            State currentState = AppManager.Instance.DataManager.MainFSM.CurrentState;           

            if (currentState as MainMenuState != null)
                nextForm = new MainMenu();

            if (currentState as GameRulesState != null)
                nextForm = new GameRules();

            if (currentState as CharacterSheetState != null)
                nextForm = new CharacterSheet();

            if (currentState as ScoreboardState != null)
                nextForm = new Scoreboard();

            if (currentState as DiceRollState != null)
                nextForm = new DiceRoll();

            if (currentState as CombatState != null)
                nextForm = new Combat();

            f.Hide();
            nextForm.Show();
            return nextForm;
        }

        public static Form ChangeForm(int i)
        {
            Form nextForm = ChangeForm(new Form(), i);

            return nextForm;
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AppManager.Instance.Initializer.Invoke();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(ChangeForm(0));
        }
    }
}