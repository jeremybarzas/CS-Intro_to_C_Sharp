using System.Collections.Generic;
using System.Xml.Serialization;

namespace WinForms_Combat_Assessment
{    
    public class Stats
    {
        [XmlIgnore]
        private Character m_attackTarget;
        [XmlIgnore]
        private Character m_itemTarget;
        [XmlIgnore]
        private Character m_spellTarget;
        [XmlIgnore]
        public Character AttackTarget
        {
            get { return m_attackTarget; }
            set { m_attackTarget = value; }
        }
        [XmlIgnore]
        public Character ItemTarget
        {
            get { return m_itemTarget; }
            set { m_itemTarget = value; }
        }
        [XmlIgnore]
        public Character SpellTarget
        {
            get { return m_spellTarget; }
            set { m_spellTarget = value; }
        }

        private List<Weapon> m_weapons;
        private List<Spell> m_spellbook;
        private List<Item> m_backpack;
        private Weapon m_activeWeapon;
        private Spell m_activeSpell;
        private Item m_activeItem;        
        private string m_name;
        private int m_health;
        private int m_mana;
        private int m_strength;
        private int m_intellect;
        private bool m_alive;
        private int m_kills;
        private int m_gold;
        private int m_turnOrder;

        public List<Weapon> Weapons
        {
            get { return m_weapons; }
            set { m_weapons = value; }
        }

        public List<Spell> Spellbook
        {
            get { return m_spellbook; }
            set { m_spellbook = value; }
        }

        public List<Item> Backpack
        {
            get { return m_backpack; }
            set { m_backpack = value; }
        }

        public Weapon ActiveWeapon
        {
            get { return m_activeWeapon; }
            set { m_activeWeapon = value; }
        }

        public Spell ActiveSpell
        {
            get { return m_activeSpell; }
            set { m_activeSpell = value; }
        }

        public Item ActiveItem
        {
            get { return m_activeItem; }
            set { m_activeItem = value; }
        }       

        public string Name
        {
            get { return m_name; }
            set { m_name = value; }
        }

        public int Health
        {
            get { return m_health; }
            set { m_health = value; }
        }

        public int Mana
        {
            get { return m_mana; }
            set { m_mana = value; }
        }

        public int Strength
        {
            get { return m_strength; }
            set { m_strength = value; }
        }

        public int Intellect
        {
            get { return m_intellect; }
            set { m_intellect = value; }
        }

        public bool Alive
        {
            get { return m_alive; }
            set { m_alive = value; }
        }

        public int Kills
        {
            get { return m_kills; }
            set { m_kills = value; }
        }

        public int Gold
        {
            get { return m_gold; }
            set { m_gold = value; }
        }

        public int TurnOrder
        {
            get { return m_turnOrder; }
            set { m_turnOrder = value; }
        }

        public Stats()
        {
            m_weapons = new List<Weapon>();
            m_spellbook = new List<Spell>();
            m_backpack = new List<Item>();
        }
    }
}