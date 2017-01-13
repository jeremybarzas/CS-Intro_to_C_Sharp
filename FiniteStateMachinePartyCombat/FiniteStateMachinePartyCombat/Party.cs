using System.Collections.Generic;

namespace FiniteStateMachinePartyCombat
{
    class Party
    {
        private List<Player> roster;
        private Player currentPlayer;
        private string m_name;

        public delegate void OnPartyEndTurn();
        public OnPartyEndTurn onPartyEndTurn;
        
        public List<Player> Roster
        {
            get { return roster; }
        }

        public Player CurrentPlayer
        {
            get { return currentPlayer; }
        }

        public string Name
        {
            get { return m_name; }
        }
        
        public void NextPlayer()
        {
            var nextPlayer = GetNextPlayer();

            if (nextPlayer == null)
            {              
                onPartyEndTurn.Invoke();
            }               
        }

        int current = 0;
        
        public Player GetNextPlayer()
        {
            if (current + 1 > roster.Count - 1)
            {
                current = 0;
                currentPlayer = roster[current];
                return null;
            }
            else
            {                
                current += 1;
                currentPlayer = roster[current];
            }

            return currentPlayer;
        }

        public void AddPlayer(Player player)
        {
            if (roster.Count <= 0)
            {
                currentPlayer = player;                
            }
            roster.Add(player);
            player.onPlayerEndTurn += NextPlayer;
        }

        public Party()
        {
            m_name = "Default Party Name";
            roster = new List<Player>();
        }

        public Party(string n)
        {
            m_name = n;
            roster = new List<Player>();
        }
    }
}