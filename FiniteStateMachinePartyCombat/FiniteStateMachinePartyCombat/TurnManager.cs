using System.Collections.Generic;

namespace FiniteStateMachinePartyCombat
{
    class TurnManager
    {
        private List<Party> parties;
        private Party currentParty;
   
        public List<Party> Parties
        {
            get { return parties; }
        }

        public Party CurrrentParty
        {
            get { return currentParty; }
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
        }
    }
}