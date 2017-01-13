using System.Collections.Generic;

namespace FiniteStateMachinePartyCombat
{
    class Party
    {
        private List<Player> m_roster;
        private string m_name;

        public List<Player> Roster
        {
            get { return m_roster; }
        }

        public string Name
        {
            get { return m_name; }
        }

        public Party()
        {
            m_name = "Default Party Name";
            m_roster = new List<Player>();
            
        }
       
        public Party(string n)
        {
            m_name = n;
            m_roster = new List<Player>();
            m_roster.ForEach(x => x.onPlayerEndTurn = NextPlayer);
            
        }
        void NextPlayer() { }
    }
}

// party needs to set next player.