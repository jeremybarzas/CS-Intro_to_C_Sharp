using System;
using System.Collections.Generic;
using System.Linq;

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

        public IGameState CurrentState
        {
            get { return m_currentState; }
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
           // m_currentState.StateBehaviour();
        }

        public void SetState(int stateID)
        {
            // foreach state in the list of states 
            // if the argument passed in is equal to the StateID 
            //set that state to current state
            m_currentState = m_states.Find(state => state.StateID == stateID);            
        }
    }
}