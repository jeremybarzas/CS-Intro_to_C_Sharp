using System.Collections.Generic;

namespace WinForms_Combat_Assessment
{
    public class Character : ITargetable
    {
        private string m_name;
        private int m_health;
        private int m_mana;
        private int m_maxHealth;
        private int m_maxMana;
        private int m_strength;
        private int m_intellect;
        private bool m_alive;
        private int m_kills;
        private int m_score;
        private int m_turnOrder;
       
        private ITargetable m_attackTarget;
        private ITargetable m_itemTarget;
        private ITargetable m_spellTarget;
        
        private Weapon m_activeWeapon;
        private Spell m_activeSpell;
        private Item m_activeItem;
        
        private List<Spell> m_spellbook;
        private List<Item> m_backpack;

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

        public int MaxHealth
        {
            get { return m_maxHealth; }
            set { m_maxHealth = value; }
        }

        public int MaxMana
        {
            get { return m_maxMana; }
            set { m_maxMana = value; }
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

        public int Score
        {
            get { return m_score; }
            set { m_score = value; }
        }

        public int TurnOrder
        {
            get { return m_turnOrder; }
            set { m_turnOrder = value; }
        }
       
        public void AddToBackpack(Item item)
        {
            m_backpack.Add(item);
        }

        public void RemoveToBackpack(Item item)
        {
            m_backpack.Remove(item);
        }

        public void RecieveWaponAction(Weapon w, int strModifer)
        {
            w.Strike(this, strModifer);
        }
        public bool AddToSpellBook(Spell spell)
        {
            if (m_spellbook.Count > 5)
                return false;
            m_spellbook.Add(spell);
            return true;
        }
        public void CastAllSpells(ITargetable tar)
        {
            foreach (var s in m_spellbook)
                s.Cast(this, 25);
        }
        public void RecieveSpellAction(Spell s, int intModifer)
        {
            s.Cast(this, intModifer);
        }

        public void RecieveItemAction(Item i)
        {
            i.Use(this);
        }

        //public void CommitAction(int strModifer, int intModifer, params ITargetable[] targets)
        //{
        //    targets[0].RecieveWaponAction(this.m_activeWeapon, strModifer);

        //    targets[1].RecieveSpellAction(this.m_activeSpell, intModifer);

        //    targets[2].RecieveItemAction(this.m_activeItem);
        //}

        public void CommitAction(ITargetable weaponTarget, ITargetable spellTarget, ITargetable itemTarget, int strModifer, int intModifer)
        {
            if(weaponTarget != null)
                weaponTarget.RecieveWaponAction(m_activeWeapon, strModifer);
            if (spellTarget != null)
                spellTarget.RecieveSpellAction(m_activeSpell, intModifer);
            if(itemTarget != null)
                itemTarget.RecieveItemAction(m_activeItem);
        }

        public Character() { }

        public Character(string n)
        {           
            m_spellbook = new List<Spell>();
            m_backpack = new List<Item>();

            Name = n;
            m_alive = true;
            m_health = 100;
            m_mana = 100;
            m_strength = 1;
            m_intellect = 1;
            m_kills = 0;
            m_score = 0;
        }       

        public Character(string n, Weapon wep, Spell spell1, Spell spell2, Item item1, Item item2, Item item3, Item item4)
        {
            m_spellbook = new List<Spell>();
            m_backpack = new List<Item>();

            Name = n;
            m_alive = true;
            m_kills = 0;
            m_score = 0;
            m_health = 100;
            m_mana = 100;
            m_strength = 1;
            m_intellect = 1;

            m_activeWeapon = wep;

            m_spellbook.Add(spell1);
            m_spellbook.Add(spell1);

            m_backpack.Add(item1);
            m_backpack.Add(item2);
            m_backpack.Add(item3);
            m_backpack.Add(item4);
        }
    }
}