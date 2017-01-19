using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedlightFSM
{
    class Transition
    {
        private State destination;
        private int m_condition;

        public Transition() { }

        public Transition(int condition, State to)
        {
            m_condition = condition;
            destination = to;
        }
    }
}