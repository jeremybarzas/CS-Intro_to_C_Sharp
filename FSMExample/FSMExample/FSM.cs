using System;
using System.Collections.Generic;

namespace FSMExample
{
    class FSM<T>
    {
        //INIT->IDLE : auto/onstartup
        //IDLE->WALK : if(keydown w,a,s,d)
        //WALK->IDLE : if(keyup w,a,s,d)
        //WALK->RUN  : if(keydown shift)
        //RUN->WALK  : if(keyup shift)

        public FSM()
        {
            states = new Dictionary<string, State>();
            var v = Enum.GetValues(typeof(T));
            foreach (var e in v)
            {
                State s = new State(e as Enum);
                states.Add(s.name, s);
            }
        }

        Dictionary<string, State> states;

        State cState;

        public void ChangeState(State state)
        {
            if (isValidTransition(state))
            {
                cState.onExit();
                cState = state;
                cState.onEnter();
            }
        }

        public bool AddState(State state)
        {
            if (transitions[state.name] == null)
            {
                transitions.Add(state.name, new List<State>());
                return true;
            }

            return false;
        }

        public bool AddTransition<V>(V a, V b)
        {
            //FSM fsm = new FSM();
            //State init = new State();
            //State idle = new State();
            //fsm.AddState(init);
            //fsm.AddState(idle);
            //usage would be fsm.AddTransition(init, idle)

            //access the transitions for the state
            State s = a as State;
            var tmp = transitions[s.name];

            return true;
        }

        public State GetState(T e)
        {
            string key = (e as State).name;
            return states[key];
        }

        private Dictionary<string, List<State>> transitions = new Dictionary<string, List<State>>();

        private bool isValidTransition(State to)
        {
            var validStates = transitions[cState.name];
            if (validStates == null)
                return false;

            foreach (var state in validStates)
            {
                if (state == to)
                    return true;
            }

            return false;
        }

        public bool Start()
        {
            return true;
        }

        public bool Update()
        {
            return true;
        }
    }
}