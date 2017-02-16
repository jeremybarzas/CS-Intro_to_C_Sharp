using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Xml.Serialization;

namespace WinForms_Combat_Assessment
{
    // fil this class with a single declaration of each individual states.
    public class stuff
    {
        public MainMenuState mms { get; set; }
        public GameRulesState grs { get; set; }        
    }
    [XmlInclude(typeof(stuff))]
    //[XmlInclude(typeof(GameRulesState))]
    public class State
    {
        
        public State() { }
        public int StateID
        {
            get; set;
        }

        public void StateBehaviour()
        {
            Debug.WriteLine("This is state" + StateID);
        }
    }
}