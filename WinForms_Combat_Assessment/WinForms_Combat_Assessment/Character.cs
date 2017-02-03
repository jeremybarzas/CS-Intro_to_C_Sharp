using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_Combat_Assessment
{
    class Character : IBackpack
    {
        private string m_name;
        private int m_health;
        private int m_mana;
        private int m_maxHealth;
        private int m_maxMana;
        private int m_strength;
        private int m_intellect;

        private ITargetable m_currentTarget;
        private ISwingable m_weapon;
        private ICastable m_spell;
        private List<IPackable> m_backpack;

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

        void SwingWeapon(Character target, ISwingable weapon)
        {
            weapon.Swing(target);
        }

        void CastSpell(Character target, ICastable spell)
        {
            spell.Cast(target);
        }
        
        void UseItem(Character target, IConsumable item)
        {
            item.Consume(target);
        }
    }
}