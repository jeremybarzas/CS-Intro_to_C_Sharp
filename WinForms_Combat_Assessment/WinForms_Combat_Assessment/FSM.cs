using System;
using System.Collections.Generic;

namespace WinForms_Combat_Assessment
{
    class FSM
    {
        private List<IGameState> m_states;
        private IGameState m_currentState;

        public FSM()
        {
            m_states = new List<IGameState>();
        }

        public FSM(List<IGameState> gs)
        {
            m_states = gs;
        }

        public void AddState(IGameState gs)
        {
            m_states.Add(gs);
        }

        public void RemoveState(IGameState gs)
        {
            m_states.Remove(gs);
        }

        public void SetState(IGameState gs)
        {
            m_currentState = gs;
        }
    }
}