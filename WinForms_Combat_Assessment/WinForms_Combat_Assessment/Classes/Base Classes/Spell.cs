using System.Xml.Serialization;

namespace WinForms_Combat_Assessment
{
    [XmlInclude(typeof(Blizzard))]
    [XmlInclude(typeof(DivineIntervention))]
    [XmlInclude(typeof(Flashburn))]
    [XmlInclude(typeof(LightningBolt))]
    [XmlInclude(typeof(MagicMissle))]
    [XmlInclude(typeof(Regeneration))]
    public abstract class Spell
    {
        public string Name;
        public int SpellPower;
        public int ManaCost;
        public abstract void Cast(Character target, int intModifer);
    }
}