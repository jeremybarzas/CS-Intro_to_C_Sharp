﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_Combat_Assessment
{
    public class DiceRollState : IGameState
    {
        public DiceRollState() { }
        public DiceRollState(int id) { m_stateID = id; }

        public void StateBehaviour()
        {

        }
        private int m_stateID;
        public int StateID
        {
            get
            {
                return m_stateID;
            }
        }
    }
}