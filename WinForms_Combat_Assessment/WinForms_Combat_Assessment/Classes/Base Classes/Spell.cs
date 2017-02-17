using System.Xml.Serialization;

namespace WinForms_Combat_Assessment
{
    public abstract class Spell
    {
        public string Name;
        public int SpellPower;
        public int ManaCost;
        public abstract void Cast(Character target, int intModifer);
    }
}