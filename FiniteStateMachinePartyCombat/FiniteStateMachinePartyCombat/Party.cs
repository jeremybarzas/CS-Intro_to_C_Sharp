using System.Collections.Generic;
using System.Xml.Serialization;

namespace FiniteStateMachinePartyCombat
{
   public class Party
    {
        private string m_name;
        private List<Player> roster;
        private Player currentPlayer;
        int currentPlayerId = 0;

        public delegate void OnPartyEndTurn();
        [XmlIgnore]
        public OnPartyEndTurn onPartyEndTurn;

        public string Name
        {
            get { return m_name; }

            set { m_name = value; }
        }

        public List<Player> Roster
        {
            get { return roster; }
        }

        public Player CurrentPlayer
        {
            get { return currentPlayer; }

            set { currentPlayer = value; }
        }

        public int CurrentPlayerId
        {
            get { return currentPlayerId; }

            set { currentPlayerId = value; }
        }

        public void NextPlayer()
        {
            var nextPlayer = GetNextPlayer();

            if (nextPlayer == null)
            {              
                onPartyEndTurn.Invoke();
            }               
        }
        
        public Player GetNextPlayer()
        {
            if (currentPlayerId + 1 > roster.Count - 1)
            {
                currentPlayerId = 0;
                currentPlayer = roster[currentPlayerId];
                return null;
            }
            else
            {                
                currentPlayerId += 1;
                currentPlayer = roster[currentPlayerId];
            }

            return currentPlayer;
        }

        public void AddPlayer(Player player)
        {
            if (roster.Count <= 0)
            {
                currentPlayer = player;
                currentPlayerId = 0;
            }

            player.onPlayerEndTurn += NextPlayer;
            roster.Add(player);
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