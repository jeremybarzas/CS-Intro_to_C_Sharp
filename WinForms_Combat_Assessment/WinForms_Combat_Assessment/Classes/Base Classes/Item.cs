using System.Xml.Serialization;

namespace WinForms_Combat_Assessment
{   
    [XmlInclude(typeof(Potion))]
    [XmlInclude(typeof(RuneStone))]
    public abstract class Item
    {
        public string Name;
        public abstract void Use(Character target);
    }
}