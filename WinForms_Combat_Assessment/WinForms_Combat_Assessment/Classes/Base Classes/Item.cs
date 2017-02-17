using System.Xml.Serialization;

namespace WinForms_Combat_Assessment
{ 
    public class Item
    {
        public string Name { get; set; }
        
        public void Use(Character target) { }

        public Item() { }

        public Item(string n) { Name = n; }
    }
}