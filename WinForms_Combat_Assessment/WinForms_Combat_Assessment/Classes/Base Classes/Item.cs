using System.Xml.Serialization;
using System.Collections.Generic;

namespace WinForms_Combat_Assessment
{   
    [XmlInclude(typeof(Potion))]
    [XmlInclude(typeof(RuneStone))]
    public abstract class Item
    {
        public string Name;
        public abstract List<int> Use(Character target);
    }
}