using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;

namespace WinForms_Combat_Assessment
{
    [System.Serializable]
    public class FSM
    {
        public FSM()
        {
            States = new List<State>();
        }

        public FSM(List<State> gs)
        {
            States = gs;
        }

        
        public State CurrentState
        {
            get; set;
        }

        [XmlElement(ElementName = "States")]
        public List<State> States
        {
            get; set;
        }

        public void AddState<T>(State gs)  where  T : State
        {
            var s = gs as T;
            States.Add(s);
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