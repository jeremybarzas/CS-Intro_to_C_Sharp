using System.Collections.Generic;
using System.Xml.Serialization;

namespace WinForms_Combat_Assessment
{
 
    public class Character : ITargetable
    {
        private Stats m_info;

        public Stats Info
        {
            get { return m_info; }
            set { m_info = value; }
        }

        public bool AddToWeapons(Weapon weapon)
        {
            if (Info.Weapons.Count >= 2)
                return false;

            Info.Weapons.Add(weapon);
            return true;
        }

        public bool AddToSpellbook(Spell spell)
        {
            if (Info.Spellbook.Count >= 2)
                return false;

            Info.Spellbook.Add(spell);
            return true;
        }

        public bool AddToBackpack(Item item)
        {
            if (Info.Backpack.Count >= 4)
                return false;

            Info.Backpack.Add(item);
            return true;
        }

        public void RemoveFromBackpack(Item item)
        {
            Info.Backpack.Remove(item);
        }

        public int RecieveWeaponAction(Weapon w, int modifier)
        {
            int value = w.Strike(this, modifier);

            if (this.Info.Health <= 0)
                this.Info.Alive = false;

            return value;
        }

        public List<int> RecieveSpellAction(Spell s, int modifier)
        {
            List<int> values = s.Cast(this, modifier);

            if (this.Info.Health <= 0)
                this.Info.Alive = false;

            return values;
        }

        public List<int> RecieveItemAction(Item i)
        {
            List<int> values = i.Use(this);

            if (this.Info.Health <= 0)
                this.Info.Alive = false;

            return values;
        }        

        public int DoWeaponAction(Character target)
        {
           int value = target.RecieveWeaponAction(this.Info.ActiveWeapon, this.Info.Strength);

            return value;
        }

        public List<int> DoSpellAction(Character target)
        {
            List<int> values = target.RecieveSpellAction(this.Info.ActiveSpell, this.Info.Intellect);
            this.Info.Mana -= this.Info.ActiveSpell.ManaCost;

            return values;
        }

        public List<int> DoItemAction(Character target)
        {
            List<int> values = target.RecieveItemAction(this.Info.ActiveItem);

            return values;
        }

        public Character()
        {
            m_info = new Stats();

            Info.Name = "Default Name";
            Info.Health = 100;
            Info.Mana = 100;
            Info.Strength = 1;
            Info.Intellect = 1;
            Info.Alive = true;
            Info.Kills = 0;
            Info.Score = 0;
            Info.TurnOrder = 0;
        }

        public Character(Character c)
        {
            this.m_info = c.m_info;

            //m_info = c.m_info;

            //m_info.Name = c.m_info.Name;
            //m_info.Health = c.m_info.Health;
            //m_info.Mana = c.m_info.Mana;
            //m_info.Strength = c.m_info.Strength;
            //m_info.Intellect = c.m_info.Intellect;
            //m_info.Alive = c.m_info.Alive;
            //m_info.Kills = c.m_info.Kills;
            //m_info.Score = c.m_info.Score;
            //m_info.TurnOrder = c.m_info.TurnOrder;
        }

        public Character(string n, Weapon w1, Weapon w2, Spell s1, Spell s2, Item i1, Item i2, Item i3, Item i4)
        {            
            m_info = new Stats();

            Info.Name = n;
            Info.Health = 100;
            Info.Mana = 100;
            Info.Strength = 1;
            Info.Intellect = 1;
            Info.Alive = true;
            Info.Kills = 0;
            Info.Score = 0;
            Info.TurnOrder = 0;

            AddToWeapons(w1);
            AddToWeapons(w2);

            AddToSpellbook(s1);
            AddToSpellbook(s2);

            AddToBackpack(i1);
            AddToBackpack(i2);
            AddToBackpack(i3);
            AddToBackpack(i4);
        }
    }
}

//public void CommitAction(int strModifer, int intModifer, params ITargetable[] targets)