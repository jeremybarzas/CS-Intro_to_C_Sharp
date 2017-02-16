using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
namespace WinForms_Combat_Assessment
{
    
    public class MainMenuState :State
    {
        public MainMenuState()  { }
        public GameRulesState throwaway { get; set; }
        public MainMenuState(int id) { StateID = id; ID = System.DateTime.UtcNow.ToString(); }

        public string ID { get; set; }
    }
}