using System.Collections.Generic;

namespace FiniteStateMachinePartyCombat
{
    public class TurnManager
    {
        private List<Party> parties;
        private Party currentParty;
        private Player currentPlayer;
   
        public List<Party> Parties
        {
            get { return parties; }
        }

        public Party CurrentParty
        {
            get { return currentParty; }

            set { currentParty = value; }
        }

        public Player CurrentPlayer
        {
            get { return currentPlayer; }

            set { currentPlayer = value; }
        }

        public void NextParty()
        {
            GetNextParty();
        }

        int current = 0;

        public Party GetNextParty()
        {
            if (current + 1 > parties.Count - 1)
            {
                current = 0;
                currentParty = parties[current];
                return null;
            }
            else
            {
                current += 1;
                currentParty = parties[current];
            }

            return currentParty;
        }

        public void AddParty(Party party)
        {
            if (parties.Count <= 0)
            {
                currentParty = party;
            }
            parties.Add(party);
            party.onPartyEndTurn += NextParty;
        }

        public TurnManager()
        {
            parties = new List<Party>();

            var Party1 = new Party();
            var Party2 = new Party();

            Party1.AddPlayer(new Player());
            Party2.AddPlayer(new Player());
            
            currentParty = parties[0];
            currentPlayer = currentParty.CurrentPlayer;
        }

        // need to base next player off of the property fo the turn manager class.
        public TurnManager(Party p1, Party p2)
        {
            parties = new List<Party>();

            AddParty(p1);
            AddParty(p2);

            currentParty = parties[0];
            currentPlayer = currentParty.CurrentPlayer;
        }
    }
}