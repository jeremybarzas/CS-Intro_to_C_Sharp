using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedlightFSM
{
    class State
    {
        private string stateName;
        private List<Transition> transitions;

        public string StateName
        {
            get { return stateName; }

            set { stateName = value; }
        }

        public State() {}

        public State(LightState a)
        {
            stateName = a.ToString();
        }

        public void AddTranstion(Transition t)
        {
            transitions.Add(t);
        }

        public void MoveNext()
        {

        }
    }
}