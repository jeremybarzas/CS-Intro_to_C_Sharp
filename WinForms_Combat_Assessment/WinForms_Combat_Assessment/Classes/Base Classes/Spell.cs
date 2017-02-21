using System.Xml.Serialization;
using System.Collections.Generic;

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
        public int Damage;
        public int Healing;
        public int ManaCost;
        public abstract List<int> Cast(Character target, int intModifer);
    }
}