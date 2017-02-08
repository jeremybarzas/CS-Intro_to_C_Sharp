using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_Combat_Assessment
{
    public class MainMenuState : IGameState
    {
        public MainMenuState() { }

        public MainMenuState(int id) { m_stateID = id; }
        
        private int m_stateID;

        public int StateID
        {
            get
            {
                return m_stateID;
            }
        }

        public void StateBehaviour()
        {
           
        }
    }
}