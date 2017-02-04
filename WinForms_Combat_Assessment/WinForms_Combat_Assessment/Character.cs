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
        private int m_turnOrder;
        private int m_score;

        private ITargetable m_currentTarget;
        private ISwingable m_weapon;
        private List<ICastable> m_spellbook;
        private List<IPackable> m_backpack;

        public string Name
        {
            get { return m_name; }
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

        public int TurnOrder
        {
            get { return m_turnOrder; }
            set { m_turnOrder = value; }
        }

        public int Score
        {
            get { return m_score; }
            set { m_score = value; }
        }

        Character() { }

        Character(string n)
        {
            m_name = n;
            m_strength = 1;
            m_intellect = 1;
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