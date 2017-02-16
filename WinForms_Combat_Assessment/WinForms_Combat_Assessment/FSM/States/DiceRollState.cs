using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_Combat_Assessment
{
    [System.Xml.Serialization.XmlInclude(typeof(DiceRollState))]
    public class DiceRollState : State
    {
        public DiceRollState() { }

        public DiceRollState(int id) { StateID = id; }
    }
}