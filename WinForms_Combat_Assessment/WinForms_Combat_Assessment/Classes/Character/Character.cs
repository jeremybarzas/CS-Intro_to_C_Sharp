using System;
using System.Collections.Generic;

namespace WinForms_Combat_Assessment
{
    public class Character : ITargetable, IBackpack
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

        private ISwingable m_weapon;
        private List<ICastable> m_spellbook;
        private List<IPackable> m_backpack;

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

        public Character()
        {
            m_alive = true;
            m_kills = 0;
            m_score = 0;

            m_strength = 1;
            m_intellect = 1;            
        }

        public Character(string n)
        {
            m_spellbook = new List<ICastable>();
            m_backpack = new List<IPackable>();

            m_name = n;
            m_alive = true;
            m_kills = 0;
            m_score = 0;

            m_strength = 1;
            m_intellect = 1;
        }

        public Character(string n, ISwingable wep, ICastable spell1, ICastable spell2, IPackable item1, IPackable item2, IPackable item3)
        {
            m_spellbook = new List<ICastable>();
            m_backpack = new List<IPackable>();

            m_name = n;
            m_alive = true;
            m_kills = 0;
            m_score = 0;

            m_strength = 1;
            m_intellect = 1;

            m_weapon = wep;

            m_spellbook.Add(spell1);
            m_spellbook.Add(spell1);
     
            m_backpack.Add(item1);
            m_backpack.Add(item2);
            m_backpack.Add(item3);
        }
        
        public void Add(IPackable item)
        {
            m_backpack.Add(item);
        }

        public void Remove(IPackable item)
        {
            m_backpack.Remove(item);
        }

        void SwingWeapon(Character target, ISwingable weapon, int Str)
        {
            weapon.Swing(target, Str);
        }

        void CastSpell(Character target, ICastable spell, int Int)
        {
            spell.Cast(target, Int);
        }
        
        void CosumeItem(Character target, IConsumable item)
        {
            item.Consume(target);
        }
    }
}