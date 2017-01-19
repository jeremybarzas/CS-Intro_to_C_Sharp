using System.Collections.Generic;

namespace FiniteStateMachinePartyCombat
{
   public class Party
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

            set { currentPlayer = value; }
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
            
            player.onPlayerEndTurn += NextPlayer;
            roster.Add(player);
        }

        public Party()
        {
            m_name = "Default Party Name";

            roster = new List<Player>();

            var Player1 = new Player();
            var Player2 = new Player();

            AddPlayer(Player1);
            AddPlayer(Player2);
        }

        public Party(string n, Player p1, Player p2, Player p3)
        {
            roster = new List<Player>();

            m_name = n;

            AddPlayer(p1);
            AddPlayer(p2);
            AddPlayer(p3);
        }
    }
}