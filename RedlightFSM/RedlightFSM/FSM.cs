using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace RedlightFSM
{
    class FSM
    {
        private List<State> states;
        private State currentState;

        public FSM()
        {
            states = new List<State>();
        }

        public FSM(State s)
        {
            states = new List<State>();
            states.Add(s);
            currentState = states[0];
        }

        private void AddState(State s)
        {
            states.Add(s);
        }

        public void StartMachine()
        {
            FeedMachine();
        }

        public void FeedMachine()
        {

        }

        public void EndMachine()
        {

        }

        private void ChangeState(State s)
        {
            currentState = s;
        }

        public void Feed(Stopwatch timer)
        {
            if (timer.Elapsed.Seconds > 60 && currentState.StateName == "Red")
            {
                ChangeState();
                timer.Stop();
                timer.Reset();
            }

            if (timer.Elapsed.Seconds > 60 && currentState.StateName == "Green")
            {
                ChangeState();
                timer.Stop();
                timer.Reset();
            }

            if (timer.Elapsed.Seconds > 15 && currentState.StateName == "Yellow")
            {
                ChangeState();
                timer.Stop();
                timer.Reset();
            }
        }  
    }
}