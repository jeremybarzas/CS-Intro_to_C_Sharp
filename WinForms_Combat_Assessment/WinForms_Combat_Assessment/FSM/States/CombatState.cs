using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_Combat_Assessment
{
    [System.Xml.Serialization.XmlInclude(typeof(CombatState))]
    public class CombatState : State
    {
        public CombatState() { }

        public CombatState(int id) { StateID = id; }
    }
}