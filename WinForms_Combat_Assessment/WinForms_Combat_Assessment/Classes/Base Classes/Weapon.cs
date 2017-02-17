using System.Xml.Serialization;

namespace WinForms_Combat_Assessment
{ 
    public class Weapon
    {
        public string Name { get; set; }

        public int Damage { get; set; }

        public void Strike(Character target, int strModifer) { }

        public Weapon() { }

        public Weapon(string n) { Name = n; }
    }
}