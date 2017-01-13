using System.Collections.Generic;

namespace FiniteStateMachinePartyCombat
{
    class TurnManager
    {
        private List<Party> m_parties;
        private Party m_curParty;
        private Player m_curPlayer;
        private int m_turnCount;
        private int m_curPartyID;
        private int m_curPlayerID;
   
        public List<Party> Parties
        {
            get { return m_parties; }
        }

        public Party CurParty
        {
            get { return m_curParty; }
        }

        public Player CurPlayer
        {
            get { return m_curPlayer; }
        }

        public int TurnCount
        {
            get { return m_turnCount; }
        }

        public int CurPlayerID
        {
            get { return m_curPlayerID; }
        }

        public void NextTurn()
        {
            m_curPlayer.EndTurn();

            if (m_curPartyID == 0 && m_curPlayerID == 2)
            {
                m_curPartyID = 1;
                m_curPlayerID = 0;

                m_curParty = m_parties[m_curPartyID];
                m_curPlayer = m_parties[m_curPartyID].Roster[m_curPlayerID];
            }

            if (m_curPartyID == 1 && m_curPlayerID == 2)
            {
                m_curPartyID = 0;
                m_curPlayerID = 0;

                m_curParty = m_parties[m_curPartyID];
                m_curPlayer = m_parties[m_curPartyID].Roster[m_curPlayerID];
            }
            
            else
            {
                m_curPlayerID++;
                m_curPlayer = m_parties[m_curPartyID].Roster[m_curPlayerID];
            }

            m_turnCount++;
        }

        public TurnManager(List<Party> p)
        {
            m_parties = p;
            m_turnCount = 0;

            m_curPartyID = 0;
            m_curPlayerID = 0;

            m_curParty = p[0];
            m_curPlayer = p[0].Roster[0];
        }
    }
}