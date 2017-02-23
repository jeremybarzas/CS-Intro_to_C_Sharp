using System.Collections.Generic;

namespace WinForms_Combat_Assessment
{
    public class FSM
    {
        private List<State> m_states;
        private State m_currentState;
        private int m_previousStateId;

        public List<State> States
        {
            get { return m_states; }            
        }        

        public State CurrentState
        {
            get { return m_currentState; }
            set { m_currentState = value; }
        }

        public int PreviousStateId
        {
            get { return m_previousStateId; }
            set { m_previousStateId = value; }
        }

        public FSM()
        {
            m_states = new List<State>();            
        }       

        public void AddState(State gs) 
        {
            m_states.Add(gs);
        }

        public void RemoveState(State gs)
        {
            m_states.Remove(gs);            
        }        

        public void SetState(int stateID)
        {
            foreach (State state in States)
            {
                if (state.StateID == stateID)
                {
                    CurrentState = States[States.IndexOf(state)];
                }
            }

            // Does the same thing as code above
            // CurrentState = States.Find(state => state.StateID == stateID);
        }
    }
}