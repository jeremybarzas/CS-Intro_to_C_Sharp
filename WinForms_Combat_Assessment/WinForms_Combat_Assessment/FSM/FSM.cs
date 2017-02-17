using System.Collections.Generic;

namespace WinForms_Combat_Assessment
{
    public class FSM
    {
        public List<State> States
        {
            get; set;
        }

        public State CurrentState
        {
            get; set;
        }

        public FSM()
        {
            States = new List<State>();            
        }       

        public void AddState(State gs) 
        {
            States.Add(gs);
        }

        public void RemoveState(State gs)
        {
            States.Remove(gs);            
        }        

        public void SetState(int stateID)
        {
            // foreach state in the list of states 
            // where if the argument passed in is equal to the StateID 
            // set that state to current state
            CurrentState = States.Find(state => state.StateID == stateID);            
        }
    }
}