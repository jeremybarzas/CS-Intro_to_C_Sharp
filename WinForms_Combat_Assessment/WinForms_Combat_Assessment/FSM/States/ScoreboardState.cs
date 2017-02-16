using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_Combat_Assessment
{
    [System.Xml.Serialization.XmlInclude(typeof(ScoreboardState))]
    public class ScoreboardState : State
    {
        public ScoreboardState() { }

        public ScoreboardState(int id) { StateID = id; }      
    }
}