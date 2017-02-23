using System.Xml.Serialization;

namespace WinForms_Combat_Assessment
{
    [XmlInclude(typeof(MainMenuState))]
    [XmlInclude(typeof(GameRulesState))]
    [XmlInclude(typeof(CharacterSheetState))]
    [XmlInclude(typeof(ScoreboardState))]
    [XmlInclude(typeof(DiceRollState))]
    [XmlInclude(typeof(CombatPhaseState))]
    public abstract class State
    {       
        public State() { }

        public State(string n, int id)
        {
            StateName = n;
            StateID = id;
        }

        public int StateID { get; set; }

        public string StateName { get; set; }
    }
}