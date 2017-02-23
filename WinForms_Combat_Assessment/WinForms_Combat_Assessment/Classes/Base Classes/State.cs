using System.Xml.Serialization;

namespace WinForms_Combat_Assessment
{
    [XmlInclude(typeof(MainMenuState))]
    [XmlInclude(typeof(GameRulesState))]
    [XmlInclude(typeof(CharacterSheetState))]
    [XmlInclude(typeof(ScoreboardState))]
    [XmlInclude(typeof(DiceRollState))]
    [XmlInclude(typeof(CombatPhaseState))]
    [XmlInclude(typeof(GameOverState))]
    [XmlInclude(typeof(LoadoutOptionsInfoState))]
    public abstract class State
    {       
        public State() { }

        public State(int id)
        {
            StateID = id;
        }

        public int StateID { get; set; }
    }
}