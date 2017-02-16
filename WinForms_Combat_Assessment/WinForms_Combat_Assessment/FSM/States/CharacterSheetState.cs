using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_Combat_Assessment
{
    [System.Xml.Serialization.XmlInclude(typeof(CharacterSheetState))]
    public class CharacterSheetState : State
    {
        public CharacterSheetState() { }

        public CharacterSheetState(int id) { StateID = id; }
    }
}