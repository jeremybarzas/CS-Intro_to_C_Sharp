using System.Collections.Generic;

namespace FiniteStateMachinePartyCombat
{
    public class TurnManager
    {
        private int turnCount;
        private List<Party> parties;
        private Party currentParty;
        int currentPartyId = 0;
   
        public int TurnCount
        {
            get { return turnCount; }

            set { turnCount = value; }
        }

        public List<Party> Parties
        {
            get { return parties; }
        }

        public Party CurrentParty
        {
            get { return currentParty; }

            set { currentParty = value; }
        }

        public int CurrentPartyId
        {
            get { return currentPartyId; }

            set { currentPartyId = value; }
        }

        public void NextParty()
        {
            GetNextParty();
        }

        public Party GetNextParty()
        {
            if (currentPartyId + 1 > parties.Count - 1)
            {
                currentPartyId = 0;
                currentParty = parties[currentPartyId];
                return null;
            }
            else
            {
                currentPartyId += 1;
                currentParty = parties[currentPartyId];
            }

            return currentParty;
        }

        public void AddParty(Party party)
        {
            if (parties.Count <= 0)
            {
                currentParty = party;
                currentPartyId = 0;
            }

            party.onPartyEndTurn += NextParty;
            parties.Add(party);
        }

        public TurnManager()
        {
            turnCount = 1;

            parties = new List<Party>();
        }
        
        public TurnManager(Party p1, Party p2)
        {
            turnCount = 1;

            parties = new List<Party>();

            AddParty(p1);
            AddParty(p2);
        }
    }
}